﻿namespace S7
{
    public enum CpuType
    {
        S7200 = 0,
        S7300 = 10,
        S7400 = 20
    }

    public enum ErrorCode
    {
        NoError = 0,
        WrongCPU_Type = 1,
        ConnectionError = 2,
        IPAddressNotAvailable,

        WrongVarFormat = 10,
        WrongNumberReceivedBytes = 11,

        SendData = 20,
        ReadData = 30,

        WriteData = 50
    }

    public enum DataType
    {
        Input = 129,
        Output = 130,
        Marker = 131,
        DataBlock = 132,
        Timer = 29,
        Counter = 28
    }

    public enum VarType
    {
        Bit,
        Byte,
        Word,
        DWord,
        Int,
        DInt,
        Real,
        String,
        Timer,
        Counter
    }
}
