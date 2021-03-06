﻿namespace ILReader.Readers {
    // The operand is a FieldRef, MethodRef, or TypeRef token.
    sealed class InlineTokOperandReader : IOperandReader {
        object IOperandReader.Read(IBinaryReader reader, Context.IOperandReaderContext context) {
            return context.ResolveMember(reader.ReadInt());
        }
    }
}