﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Integers of differing sizes and range: \n");

/* ---------
 * C# BASICS
 * --------*/

/* Data types */

/* Integers of differing sizes and ranges */

// byte 

byte aSingleByte = 30;
byte byteByteUsage = 1;
bool allowNegatives = false;
byte minimumByte = 0;
byte maximumByte = 255;

Console.WriteLine($"byte:    Byte usage: {byteByteUsage} || Allows negatives: {allowNegatives} || Minimum byte:           {minimumByte} || Maximum byte:                   {maximumByte} || byte example: {aSingleByte} \n");

// short

short shortByteUsage = 2;
bool shortAllowNegatives = true;
short minimumShort = -32768;
short maximumShort = 32767;
short aShortNumber = 500;

Console.WriteLine($"short:   Byte usage: {shortByteUsage} || Allows negatives: {shortAllowNegatives}  || Minimum short:     {minimumShort} || Maximum short:                {maximumShort} || short example: {aShortNumber} \n");

//int

int intByteUsage = 4;
bool intAllowNegatives = true;
int minimumInt = -2_147_483_648;
int maximumInt = 2_147_483_647;
int aIntNumber = 50_000;

Console.WriteLine($"int:     Byte usage: {intByteUsage} || Allows negatives: {intAllowNegatives}  || Minimum int:  {minimumInt} || Maximum int:             {maximumInt} || int example: {aIntNumber} \n");


//long

long longByteUsage = 8;
bool longAllowNegatives = true;
long minimumLong = -2_147_483_648;
long maximumLong = 2_147_483_647;
long aLongNumber = 5_222_352_136_354_575_837;

Console.WriteLine($"long:    Byte usage: {longByteUsage} || Allows negatives: {longAllowNegatives}  || Minimum long: {minimumLong} || Maximum long:            {maximumLong} || long example: {aLongNumber} \n");

//sbyte

sbyte sbyteByteUsage = 1;
bool sbyteAllowNegatives = true;
sbyte minimumSbyte = -128;
sbyte maximumSbyte = 127;
sbyte aSbyteNumber = -50;

Console.WriteLine($"sbyte:   Byte usage: {sbyteByteUsage} || Allows negatives: {sbyteAllowNegatives}  || Minimum sbyte:       {minimumSbyte} || Maximum sbyte:                  {maximumSbyte} || sbyte example: {aSbyteNumber} \n");

//ushort

ushort ushortByteUsage = 1;
bool ushortAllowNegatives = false;
ushort minimumUshort = 0;
ushort maximumUshort = 65_535;
ushort aUshortNumber = 11_111;

Console.WriteLine($"ushort:  Byte usage: {ushortByteUsage} || Allows negatives: {ushortAllowNegatives} || Minimum ushort:         {minimumUshort} || Maximum ushort:               {maximumUshort} || ushort example: {aUshortNumber} \n");

//uint

uint uintByteUsage = 4;
bool uintAllowNegatives = false;
uint minimumUint = 0;
uint maximumUint = 4_294_967_295;
uint aUintNumber = 2_000_967_295;

Console.WriteLine($"uint:    Byte usage: {uintByteUsage} || Allows negatives: {uintAllowNegatives} || Minimum uint:           {minimumUint} || Maximum uint:            {maximumUint} || uint example: {aUintNumber} \n");

//ulong

ulong ulongByteUsage = 8;
bool ulongAllowNegatives = false;
ulong minimumulong = 0;
ulong maximumulong = 18_446_744_073_709_551_615;
ulong aUlongNumber = 17_226_114_073_239_541_111;

Console.WriteLine($"ulong:   Byte usage: {ulongByteUsage} || Allows negatives: {ulongAllowNegatives} || Minimum ulong:          {minimumulong} || Maximum ulong: {maximumulong} || ulong example: {aUlongNumber} \n");


Console.WriteLine("\n");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("\n");
