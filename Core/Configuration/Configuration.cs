﻿namespace ILReader {
    using System.Collections.Generic;
    using System.Reflection;
    using System.Reflection.Emit;
    using ILReader.Monads;
    using ILReader.Readers;

    public static class Configuration {
        public static IILReaderConfiguration Resolve(System.IO.Stream dump) {
            return DumpConfiguration.Default;
        }
        public static IILReaderConfiguration Resolve(MethodBase method) {
            if(method is DynamicMethod)
                return DynamicMethodConfiguration.Default;
            if(Equals(method.@Get(m => m.GetType()), RTTypes.RTDynamicMethodType))
                return RTDynamicMethodConfiguration.Default;
            return StandardConfiguration.Default;
        }
    }
    //
    abstract class ConfigurationBase : IILReaderConfiguration {
        static Dictionary<MethodBase, IILReader> readers = new Dictionary<MethodBase, IILReader>();
        protected virtual void ResetReader(MethodBase methodBase) {
            readers.Remove(methodBase);
        }
        protected virtual void ResetReaders() {
            readers.Clear();
        }
        protected virtual IILReader GetOrCreateReader(MethodBase methodBase) {
            IILReader reader;
            if(!readers.TryGetValue(methodBase, out reader)) {
                var factory = CreateILReaderFactory(methodBase);
                reader = factory.CreateReader();
                readers.Add(methodBase, reader);
            }
            return reader;
        }
        protected virtual IILReader CreateReader(System.IO.Stream dump) {
            var factory = CreateILReaderFactory(dump);
            return factory.CreateReader();
        }
        protected virtual IILReaderFactory CreateILReaderFactory(System.IO.Stream dump) {
            return new ILReaderFactory(dump, this);
        }
        protected virtual IILReaderFactory CreateILReaderFactory(MethodBase methodBase) {
            return new ILReaderFactory(methodBase, this);
        }
        protected virtual IBinaryReader CreateBinaryReader(byte[] bytes) {
            return new BinaryReader(bytes);
        }
        //
        protected abstract Context.IOperandReaderContext CreateOperandReaderContext(MethodBase methodBase);
        protected abstract Context.IOperandReaderContext CreateOperandReaderContext(System.IO.Stream dump);
        #region IILReaderConfiguration
        readonly static object syncObj = new object();
        IILReader IILReaderConfiguration.GetReader(System.IO.Stream dump) {
            lock(syncObj) return CreateReader(dump);
        }
        IILReader IILReaderConfiguration.GetReader(MethodBase methodBase) {
            lock(syncObj) return GetOrCreateReader(methodBase);
        }
        void IILReaderConfiguration.Reset(MethodBase methodBase) {
            lock(syncObj) ResetReader(methodBase);
        }
        void IILReaderConfiguration.Reset() {
            lock(syncObj) ResetReaders();
        }
        IBinaryReader IILReaderConfiguration.CreateBinaryReader(byte[] bytes) {
            return CreateBinaryReader(bytes);
        }
        Context.IOperandReaderContext IILReaderConfiguration.CreateOperandReaderContext(MethodBase methodBase) {
            return CreateOperandReaderContext(methodBase);
        }
        Context.IOperandReaderContext IILReaderConfiguration.CreateOperandReaderContext(System.IO.Stream dump) {
            return CreateOperandReaderContext(dump);
        }
        #endregion
    }
    //
    abstract class RealConfiguration : ConfigurationBase {
        protected override Context.IOperandReaderContext CreateOperandReaderContext(System.IO.Stream dump) {
            throw new System.NotImplementedException();
        }
    }
    class StandardConfiguration : RealConfiguration {
        protected override Context.IOperandReaderContext CreateOperandReaderContext(MethodBase methodBase) {
            return new Context.OperandReaderContext(methodBase, methodBase.GetMethodBody());
        }
        static readonly internal IILReaderConfiguration Default = new StandardConfiguration();
    }
    class DynamicMethodConfiguration : RealConfiguration {
        protected override Context.IOperandReaderContext CreateOperandReaderContext(MethodBase methodBase) {
            return new Context.OperandReaderContext_DynamicMethod((DynamicMethod)methodBase);
        }
        static readonly internal IILReaderConfiguration Default = new DynamicMethodConfiguration();
    }
    class RTDynamicMethodConfiguration : RealConfiguration {
        protected override Context.IOperandReaderContext CreateOperandReaderContext(MethodBase methodBase) {
            var ownerMethod = RTTypes.GetOwnerDynamicMethod(methodBase);
            return new Context.OperandReaderContext_DynamicMethod(ownerMethod);
        }
        static readonly internal IILReaderConfiguration Default = new RTDynamicMethodConfiguration();
    }
    //
    class DumpConfiguration : ConfigurationBase {
        protected override Context.IOperandReaderContext CreateOperandReaderContext(MethodBase methodBase) {
            throw new System.NotImplementedException();
        }
        protected override Context.IOperandReaderContext CreateOperandReaderContext(System.IO.Stream dump) {
            var ilReaderDump = new Dump.InstructionReaderDump(dump);
            return new Context.OperandReaderContextDump(ilReaderDump);
        }
        static readonly internal IILReaderConfiguration Default = new DumpConfiguration();
    }
}