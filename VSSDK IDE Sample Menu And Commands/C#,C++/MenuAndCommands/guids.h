﻿// guids.h: definitions of GUIDs/IIDs/CLSIDs used in this VsPackage

/*
Do not use #pragma once, as this file needs to be included twice.  Once to declare the externs
for the GUIDs, and again right after including initguid.h to actually define the GUIDs.
*/



// package guid
// { ab7eeef6-3221-4aef-b91c-240b508d9c5a }
#define guidMenuAndCommandsPkg { 0xAB7EEEF6, 0x3221, 0x4AEF, { 0xB9, 0x1C, 0x24, 0xB, 0x50, 0x8D, 0x9C, 0x5A } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_MenuAndCommands,
0xAB7EEEF6, 0x3221, 0x4AEF, 0xB9, 0x1C, 0x24, 0xB, 0x50, 0x8D, 0x9C, 0x5A );
#endif

// Command set guid for our commands (used with IOleCommandTarget)
// { abcfffde-f16e-4a8d-9514-e4f365ed0556 }
#define guidMenuAndCommandsCmdSet { 0xABCFFFDE, 0xF16E, 0x4A8D, { 0x95, 0x14, 0xE4, 0xF3, 0x65, 0xED, 0x5, 0x56 } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_MenuAndCommandsCmdSet, 
0xABCFFFDE, 0xF16E, 0x4A8D, 0x95, 0x14, 0xE4, 0xF3, 0x65, 0xED, 0x5, 0x56 );
#endif

//Guid for the image list referenced in the VSCT file
// { 5ab19c71-3a3b-4aa0-aa1f-a123c53228b4 }
#define guidImages { 0x5AB19C71, 0x3A3B, 0x4AA0, { 0xAA, 0x1F, 0xA1, 0x23, 0xC5, 0x32, 0x28, 0xB4 } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_Images, 
0x5AB19C71, 0x3A3B, 0x4AA0, 0xAA, 0x1F, 0xA1, 0x23, 0xC5, 0x32, 0x28, 0xB4 );
#endif


