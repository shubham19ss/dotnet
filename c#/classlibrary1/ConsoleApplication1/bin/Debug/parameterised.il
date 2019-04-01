
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly ConsoleApplication1
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 13 43 6F 6E 73 6F 6C 65 41 70 70 6C 69 63   // ...ConsoleApplic
                                                                                              61 74 69 6F 6E 31 00 00 )                         // ation1..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 13 43 6F 6E 73 6F 6C 65 41 70 70 6C 69 63   // ...ConsoleApplic
                                                                                                61 74 69 6F 6E 31 00 00 )                         // ation1..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 39 00 00 )                            //  2019..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 30 34 30 32 34 65 36 35 2D 35 62 36 33   // ..$04024e65-5b63
                                                                                                  2D 34 36 64 36 2D 61 65 36 65 2D 38 62 66 37 62   // -46d6-ae6e-8bf7b
                                                                                                  65 37 62 30 64 36 30 00 00 )                      // e7b0d60..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 35 2E 32 01   // ,Version=v4.5.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 35 2E 32 )          // amework 4.5.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module ConsoleApplication1.exe
// MVID: {433FD2BC-629B-4E28-92B4-608BE118BD24}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x07600000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit ConsoleApplication1.Program
       extends [mscorlib]System.Object
{
  .field public int32 x
  .field private string s
  .method private hidebysig specialname rtspecialname 
          instance void  .ctor(int32 a,
                               string b) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  stfld      int32 ConsoleApplication1.Program::x
    IL_000f:  ldarg.0
    IL_0010:  ldarg.2
    IL_0011:  stfld      string ConsoleApplication1.Program::s
    IL_0016:  ret
  } // end of method Program::.ctor

  .method private hidebysig instance void 
          print() cil managed
  {
    // Code size       26 (0x1a)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 ConsoleApplication1.Program::x
    IL_0007:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_000c:  nop
    IL_000d:  ldarg.0
    IL_000e:  ldfld      string ConsoleApplication1.Program::s
    IL_0013:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0018:  nop
    IL_0019:  ret
  } // end of method Program::print

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       28 (0x1c)
    .maxstack  2
    .locals init ([0] class ConsoleApplication1.Program obj)
    IL_0000:  nop
    IL_0001:  ldc.i4.s   20
    IL_0003:  ldstr      "manee"
    IL_0008:  newobj     instance void ConsoleApplication1.Program::.ctor(int32,
                                                                          string)
    IL_000d:  stloc.0
    IL_000e:  ldloc.0
    IL_000f:  callvirt   instance void ConsoleApplication1.Program::print()
    IL_0014:  nop
    IL_0015:  call       int32 [mscorlib]System.Console::Read()
    IL_001a:  pop
    IL_001b:  ret
  } // end of method Program::Main

} // end of class ConsoleApplication1.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\cdac\Desktop\c#\classlibrary1\ConsoleApplication1\bin\Debug\parameterised.res
