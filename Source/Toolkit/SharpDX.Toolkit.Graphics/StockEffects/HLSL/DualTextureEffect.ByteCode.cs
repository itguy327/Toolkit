﻿//------------------------------------------------------------------------------
// <auto-generated>
//     SharpDX Toolkit Compiler File Generated:
//     Effect [Toolkit::DualTextureEffect]
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpDX.Toolkit.Graphics 
{
    public partial class DualTextureEffect
    {
        private static readonly SharpDX.Toolkit.Graphics.EffectData effectBytecode = SharpDX.Toolkit.Graphics.EffectData.Load(new byte[] {
84, 75, 70, 88, 243, 32, 0, 0, 61, 57, 217, 181, 83, 72, 68, 82, 102, 32, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 145, 0, 0, 224, 8, 68, 88, 66, 67, 19, 225, 50, 25, 41, 84, 181, 120, 121, 157, 134, 126, 82, 105, 149, 42, 1, 0, 0, 0, 96, 4, 0, 0, 4, 0, 0, 0, 
48, 0, 0, 0, 148, 1, 0, 0, 76, 3, 0, 0, 188, 3, 0, 0, 65, 111, 110, 57, 92, 1, 0, 0, 92, 1, 0, 0, 0, 2, 254, 255, 16, 1, 0, 0, 76, 0, 0, 0, 3, 0, 36, 0, 0, 0, 72, 0, 0, 0, 72, 0, 0, 0, 36, 0, 1, 0, 72, 0, 0, 0, 0, 0, 
1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 4, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 254, 255, 81, 0, 0, 5, 7, 0, 15, 160, 0, 0, 0, 0, 0, 0, 128, 63, 0, 0, 0, 0, 0, 0, 0, 0, 
31, 0, 0, 2, 5, 0, 0, 128, 0, 0, 15, 144, 31, 0, 0, 2, 5, 0, 1, 128, 1, 0, 15, 144, 31, 0, 0, 2, 5, 0, 2, 128, 2, 0, 15, 144, 9, 0, 0, 3, 0, 0, 1, 128, 0, 0, 228, 144, 2, 0, 228, 160, 11, 0, 0, 3, 0, 0, 1, 128, 0, 0, 0, 128, 
7, 0, 0, 160, 10, 0, 0, 3, 1, 0, 8, 224, 0, 0, 0, 128, 7, 0, 85, 160, 5, 0, 0, 3, 0, 0, 15, 128, 0, 0, 85, 144, 4, 0, 228, 160, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 0, 144, 3, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 
0, 0, 170, 144, 5, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 255, 144, 6, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 3, 192, 0, 0, 255, 128, 0, 0, 228, 160, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 12, 192, 0, 0, 228, 128, 
1, 0, 0, 2, 0, 0, 15, 224, 1, 0, 228, 160, 1, 0, 0, 2, 1, 0, 7, 224, 7, 0, 0, 160, 1, 0, 0, 2, 2, 0, 3, 224, 1, 0, 228, 144, 1, 0, 0, 2, 2, 0, 12, 224, 2, 0, 20, 144, 255, 255, 0, 0, 83, 72, 68, 82, 176, 1, 0, 0, 64, 0, 1, 0, 
108, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 0, 0, 0, 0, 3, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 1, 0, 0, 0, 4, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 0, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 1, 0, 0, 0, 95, 0, 0, 3, 
50, 16, 16, 0, 2, 0, 0, 0, 101, 0, 0, 3, 242, 32, 16, 0, 0, 0, 0, 0, 101, 0, 0, 3, 242, 32, 16, 0, 1, 0, 0, 0, 101, 0, 0, 3, 50, 32, 16, 0, 2, 0, 0, 0, 101, 0, 0, 3, 194, 32, 16, 0, 2, 0, 0, 0, 103, 0, 0, 4, 242, 32, 16, 0, 
3, 0, 0, 0, 1, 0, 0, 0, 104, 0, 0, 2, 1, 0, 0, 0, 54, 0, 0, 6, 242, 32, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 17, 32, 0, 8, 130, 32, 16, 0, 1, 0, 0, 0, 70, 30, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 
0, 0, 0, 0, 2, 0, 0, 0, 54, 0, 0, 8, 114, 32, 16, 0, 1, 0, 0, 0, 2, 64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 54, 0, 0, 5, 50, 32, 16, 0, 2, 0, 0, 0, 70, 16, 16, 0, 1, 0, 0, 0, 54, 0, 0, 5, 
194, 32, 16, 0, 2, 0, 0, 0, 6, 20, 16, 0, 2, 0, 0, 0, 56, 0, 0, 8, 242, 0, 16, 0, 0, 0, 0, 0, 86, 21, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 1, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 6, 16, 16, 0, 
0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 166, 26, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 2, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 
50, 0, 0, 10, 242, 32, 16, 0, 3, 0, 0, 0, 246, 31, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 3, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 104, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 80, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 92, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 
3, 3, 0, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 171, 171, 79, 83, 71, 78, 156, 0, 0, 0, 5, 0, 0, 0, 8, 0, 0, 0, 128, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 
15, 0, 0, 0, 128, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 15, 0, 0, 0, 134, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 12, 0, 0, 134, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 
3, 0, 0, 0, 2, 0, 0, 0, 12, 3, 0, 0, 143, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 15, 0, 0, 0, 67, 79, 76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 
177, 73, 225, 32, 3, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 1, 2, 0, 3, 3, 0, 0, 1, 148, 1, 68, 88, 66, 67, 178, 
20, 119, 111, 49, 227, 166, 95, 225, 65, 190, 10, 21, 91, 177, 29, 1, 0, 0, 0, 148, 0, 0, 0, 1, 0, 0, 0, 36, 0, 0, 0, 73, 83, 71, 78, 104, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 
0, 0, 0, 15, 15, 0, 0, 92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 92, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 
111, 110, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 171, 171, 45, 88, 244, 181, 5, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 5, 67, 79, 76, 79, 82, 1, 1, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 2, 0, 3, 3, 0, 0, 8, 84, 
69, 88, 67, 79, 79, 82, 68, 1, 2, 0, 3, 12, 0, 0, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 3, 1, 3, 15, 0, 0, 0, 0, 0, 0, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 48, 3, 12, 68, 105, 102, 102, 117, 115, 101, 67, 111, 108, 111, 
114, 1, 3, 0, 0, 16, 1, 4, 0, 8, 70, 111, 103, 67, 111, 108, 111, 114, 1, 3, 16, 0, 12, 1, 3, 0, 9, 70, 111, 103, 86, 101, 99, 116, 111, 114, 1, 3, 32, 0, 16, 1, 4, 0, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 64, 1, 13, 
87, 111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 2, 3, 0, 0, 64, 4, 4, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 4, 26, 1, 1, 0, 4, 0, 0, 0, 0, 
0, 145, 0, 0, 188, 7, 68, 88, 66, 67, 189, 178, 200, 12, 194, 138, 101, 184, 232, 103, 124, 24, 246, 156, 250, 109, 1, 0, 0, 0, 188, 3, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 92, 1, 0, 0, 8, 3, 0, 0, 136, 3, 0, 0, 65, 111, 110, 57, 36, 1, 0, 0, 36, 1, 
0, 0, 0, 2, 255, 255, 236, 0, 0, 0, 56, 0, 0, 0, 1, 0, 44, 0, 0, 0, 56, 0, 0, 0, 56, 0, 2, 0, 36, 0, 0, 0, 56, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 255, 255, 81, 0, 0, 5, 1, 0, 
15, 160, 0, 0, 0, 64, 0, 0, 0, 64, 0, 0, 0, 64, 0, 0, 128, 63, 31, 0, 0, 2, 0, 0, 0, 128, 0, 0, 15, 176, 31, 0, 0, 2, 0, 0, 0, 128, 1, 0, 15, 176, 31, 0, 0, 2, 0, 0, 0, 128, 2, 0, 15, 176, 31, 0, 0, 2, 0, 0, 0, 144, 0, 8, 
15, 160, 31, 0, 0, 2, 0, 0, 0, 144, 1, 8, 15, 160, 66, 0, 0, 3, 0, 0, 15, 128, 2, 0, 228, 176, 0, 8, 228, 160, 1, 0, 0, 2, 1, 0, 3, 128, 2, 0, 27, 176, 66, 0, 0, 3, 1, 0, 15, 128, 1, 0, 228, 128, 1, 8, 228, 160, 5, 0, 0, 3, 1, 0, 
15, 128, 1, 0, 228, 128, 0, 0, 228, 176, 5, 0, 0, 3, 0, 0, 15, 128, 0, 0, 228, 128, 1, 0, 228, 160, 5, 0, 0, 3, 0, 0, 15, 128, 1, 0, 228, 128, 0, 0, 228, 128, 4, 0, 0, 4, 1, 0, 7, 128, 0, 0, 228, 160, 0, 0, 255, 128, 0, 0, 228, 129, 4, 0, 
0, 4, 0, 0, 7, 128, 1, 0, 255, 176, 1, 0, 228, 128, 0, 0, 228, 128, 1, 0, 0, 2, 0, 8, 15, 128, 0, 0, 228, 128, 255, 255, 0, 0, 83, 72, 68, 82, 164, 1, 0, 0, 64, 0, 0, 0, 105, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 0, 0, 0, 0, 2, 0, 
0, 0, 90, 0, 0, 3, 0, 96, 16, 0, 0, 0, 0, 0, 90, 0, 0, 3, 0, 96, 16, 0, 1, 0, 0, 0, 88, 24, 0, 4, 0, 112, 16, 0, 0, 0, 0, 0, 85, 85, 0, 0, 88, 24, 0, 4, 0, 112, 16, 0, 1, 0, 0, 0, 85, 85, 0, 0, 98, 16, 0, 3, 242, 16, 
16, 0, 0, 0, 0, 0, 98, 16, 0, 3, 130, 16, 16, 0, 1, 0, 0, 0, 98, 16, 0, 3, 50, 16, 16, 0, 2, 0, 0, 0, 98, 16, 0, 3, 194, 16, 16, 0, 2, 0, 0, 0, 101, 0, 0, 3, 242, 32, 16, 0, 0, 0, 0, 0, 104, 0, 0, 2, 2, 0, 0, 0, 69, 0, 
0, 9, 242, 0, 16, 0, 0, 0, 0, 0, 230, 26, 16, 0, 2, 0, 0, 0, 70, 126, 16, 0, 1, 0, 0, 0, 0, 96, 16, 0, 1, 0, 0, 0, 56, 0, 0, 7, 242, 0, 16, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 70, 30, 16, 0, 0, 0, 0, 0, 69, 0, 
0, 9, 242, 0, 16, 0, 1, 0, 0, 0, 70, 16, 16, 0, 2, 0, 0, 0, 70, 126, 16, 0, 0, 0, 0, 0, 0, 96, 16, 0, 0, 0, 0, 0, 56, 0, 0, 10, 242, 0, 16, 0, 1, 0, 0, 0, 70, 14, 16, 0, 1, 0, 0, 0, 2, 64, 0, 0, 0, 0, 0, 64, 0, 0, 
0, 64, 0, 0, 0, 64, 0, 0, 128, 63, 56, 0, 0, 7, 242, 0, 16, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 70, 14, 16, 0, 1, 0, 0, 0, 50, 0, 0, 11, 114, 0, 16, 0, 1, 0, 0, 0, 70, 130, 32, 0, 0, 0, 0, 0, 1, 0, 0, 0, 246, 15, 
16, 0, 0, 0, 0, 0, 70, 2, 16, 128, 65, 0, 0, 0, 0, 0, 0, 0, 50, 0, 0, 9, 114, 32, 16, 0, 0, 0, 0, 0, 246, 31, 16, 0, 1, 0, 0, 0, 70, 2, 16, 0, 1, 0, 0, 0, 70, 2, 16, 0, 0, 0, 0, 0, 54, 0, 0, 5, 130, 32, 16, 0, 0, 0, 
0, 0, 58, 0, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 120, 0, 0, 0, 4, 0, 0, 0, 8, 0, 0, 0, 104, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 104, 0, 0, 0, 1, 0, 0, 0, 0, 0, 
0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 15, 8, 0, 0, 110, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 110, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 12, 12, 0, 0, 67, 79, 
76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 79, 83, 71, 78, 44, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 83, 86, 95, 84, 97, 114, 103, 101, 116, 0, 
171, 171, 248, 164, 126, 134, 4, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 5, 67, 79, 76, 79, 82, 1, 1, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 2, 0, 3, 3, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 1, 2, 0, 3, 12, 0, 
0, 0, 0, 0, 0, 0, 1, 9, 83, 86, 95, 84, 97, 114, 103, 101, 116, 0, 0, 64, 3, 15, 0, 0, 0, 0, 0, 0, 0, 1, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 48, 3, 12, 68, 105, 102, 102, 117, 115, 101, 67, 111, 108, 111, 114, 1, 3, 0, 0, 16, 1, 4, 0, 
8, 70, 111, 103, 67, 111, 108, 111, 114, 1, 3, 16, 0, 12, 1, 3, 0, 9, 70, 111, 103, 86, 101, 99, 116, 111, 114, 1, 3, 32, 0, 16, 1, 4, 0, 5, 14, 84, 101, 120, 116, 117, 114, 101, 83, 97, 109, 112, 108, 101, 114, 4, 10, 0, 1, 15, 84, 101, 120, 116, 117, 114, 101, 50, 
83, 97, 109, 112, 108, 101, 114, 4, 10, 1, 1, 7, 84, 101, 120, 116, 117, 114, 101, 4, 7, 0, 1, 8, 84, 101, 120, 116, 117, 114, 101, 50, 4, 7, 1, 1, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 0, 0, 0, 0, 0, 0, 0, 145, 0, 0, 156, 7, 68, 
88, 66, 67, 188, 43, 163, 103, 151, 56, 155, 212, 151, 14, 131, 4, 66, 85, 104, 46, 1, 0, 0, 0, 156, 3, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 52, 1, 0, 0, 160, 2, 0, 0, 16, 3, 0, 0, 65, 111, 110, 57, 252, 0, 0, 0, 252, 0, 0, 0, 0, 2, 254, 255, 188, 
0, 0, 0, 64, 0, 0, 0, 2, 0, 36, 0, 0, 0, 60, 0, 0, 0, 60, 0, 0, 0, 36, 0, 1, 0, 60, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 4, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 254, 255, 31, 0, 0, 2, 5, 
0, 0, 128, 0, 0, 15, 144, 31, 0, 0, 2, 5, 0, 1, 128, 1, 0, 15, 144, 31, 0, 0, 2, 5, 0, 2, 128, 2, 0, 15, 144, 5, 0, 0, 3, 0, 0, 15, 128, 0, 0, 85, 144, 3, 0, 228, 160, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 0, 144, 2, 0, 228, 160, 0, 
0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 170, 144, 4, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 255, 144, 5, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 3, 192, 0, 0, 255, 128, 0, 0, 228, 160, 0, 0, 228, 128, 1, 
0, 0, 2, 0, 0, 12, 192, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 15, 224, 1, 0, 228, 160, 1, 0, 0, 2, 1, 0, 3, 224, 1, 0, 228, 144, 1, 0, 0, 2, 1, 0, 12, 224, 2, 0, 20, 144, 255, 255, 0, 0, 83, 72, 68, 82, 100, 1, 0, 0, 64, 0, 1, 0, 89, 
0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 0, 0, 0, 0, 1, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 1, 0, 0, 0, 4, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 0, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 1, 0, 0, 0, 95, 0, 0, 3, 50, 
16, 16, 0, 2, 0, 0, 0, 101, 0, 0, 3, 242, 32, 16, 0, 0, 0, 0, 0, 101, 0, 0, 3, 50, 32, 16, 0, 1, 0, 0, 0, 101, 0, 0, 3, 194, 32, 16, 0, 1, 0, 0, 0, 103, 0, 0, 4, 242, 32, 16, 0, 2, 0, 0, 0, 1, 0, 0, 0, 104, 0, 0, 2, 1, 
0, 0, 0, 54, 0, 0, 6, 242, 32, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 54, 0, 0, 5, 50, 32, 16, 0, 1, 0, 0, 0, 70, 16, 16, 0, 1, 0, 0, 0, 54, 0, 0, 5, 194, 32, 16, 0, 1, 0, 0, 0, 6, 20, 16, 0, 2, 
0, 0, 0, 56, 0, 0, 8, 242, 0, 16, 0, 0, 0, 0, 0, 86, 21, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 1, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 6, 16, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 0, 
0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 166, 26, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 2, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 32, 16, 0, 2, 0, 0, 0, 246, 
31, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 3, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 104, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 
0, 0, 0, 15, 15, 0, 0, 92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 92, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 
111, 110, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 171, 171, 79, 83, 71, 78, 132, 0, 0, 0, 4, 0, 0, 0, 8, 0, 0, 0, 104, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 110, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 12, 0, 0, 110, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 12, 3, 0, 0, 119, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 15, 0, 0, 0, 67, 
79, 76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 106, 197, 106, 222, 3, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 1, 0, 3, 
3, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 1, 2, 0, 3, 3, 0, 0, 1, 148, 1, 68, 88, 66, 67, 178, 20, 119, 111, 49, 227, 166, 95, 225, 65, 190, 10, 21, 91, 177, 29, 1, 0, 0, 0, 148, 0, 0, 0, 1, 0, 0, 0, 36, 0, 0, 0, 73, 83, 71, 78, 104, 0, 
0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 92, 0, 0, 0, 1, 0, 
0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 171, 171, 45, 88, 244, 181, 4, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 
67, 79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 1, 1, 0, 3, 12, 0, 0, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 2, 1, 3, 15, 0, 0, 0, 0, 0, 0, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 
48, 3, 12, 68, 105, 102, 102, 117, 115, 101, 67, 111, 108, 111, 114, 1, 3, 0, 0, 16, 1, 4, 0, 8, 70, 111, 103, 67, 111, 108, 111, 114, 1, 3, 16, 0, 12, 1, 3, 0, 9, 70, 111, 103, 86, 101, 99, 116, 111, 114, 1, 3, 32, 0, 16, 1, 4, 0, 16, 80, 114, 111, 106, 101, 
99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 64, 1, 13, 87, 111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 2, 3, 0, 0, 64, 4, 4, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 
116, 114, 105, 120, 4, 26, 1, 1, 0, 4, 0, 0, 0, 0, 0, 145, 0, 0, 244, 5, 68, 88, 66, 67, 120, 86, 234, 73, 202, 99, 189, 249, 140, 155, 186, 105, 184, 237, 236, 213, 1, 0, 0, 0, 244, 2, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 28, 1, 0, 0, 88, 2, 0, 0, 
192, 2, 0, 0, 65, 111, 110, 57, 228, 0, 0, 0, 228, 0, 0, 0, 0, 2, 255, 255, 184, 0, 0, 0, 44, 0, 0, 0, 0, 0, 44, 0, 0, 0, 44, 0, 0, 0, 44, 0, 2, 0, 36, 0, 0, 0, 44, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 2, 255, 255, 81, 0, 0, 5, 
0, 0, 15, 160, 0, 0, 0, 64, 0, 0, 0, 64, 0, 0, 0, 64, 0, 0, 128, 63, 31, 0, 0, 2, 0, 0, 0, 128, 0, 0, 15, 176, 31, 0, 0, 2, 0, 0, 0, 128, 1, 0, 15, 176, 31, 0, 0, 2, 0, 0, 0, 144, 0, 8, 15, 160, 31, 0, 0, 2, 0, 0, 0, 144, 
1, 8, 15, 160, 66, 0, 0, 3, 0, 0, 15, 128, 1, 0, 228, 176, 0, 8, 228, 160, 1, 0, 0, 2, 1, 0, 3, 128, 1, 0, 27, 176, 66, 0, 0, 3, 1, 0, 15, 128, 1, 0, 228, 128, 1, 8, 228, 160, 5, 0, 0, 3, 1, 0, 15, 128, 1, 0, 228, 128, 0, 0, 228, 176, 
5, 0, 0, 3, 0, 0, 15, 128, 0, 0, 228, 128, 0, 0, 228, 160, 5, 0, 0, 3, 0, 0, 15, 128, 1, 0, 228, 128, 0, 0, 228, 128, 1, 0, 0, 2, 0, 8, 15, 128, 0, 0, 228, 128, 255, 255, 0, 0, 83, 72, 68, 82, 52, 1, 0, 0, 64, 0, 0, 0, 77, 0, 0, 0, 
89, 0, 0, 4, 70, 142, 32, 0, 0, 0, 0, 0, 1, 0, 0, 0, 90, 0, 0, 3, 0, 96, 16, 0, 0, 0, 0, 0, 90, 0, 0, 3, 0, 96, 16, 0, 1, 0, 0, 0, 88, 24, 0, 4, 0, 112, 16, 0, 0, 0, 0, 0, 85, 85, 0, 0, 88, 24, 0, 4, 0, 112, 16, 0, 
1, 0, 0, 0, 85, 85, 0, 0, 98, 16, 0, 3, 242, 16, 16, 0, 0, 0, 0, 0, 98, 16, 0, 3, 50, 16, 16, 0, 1, 0, 0, 0, 98, 16, 0, 3, 194, 16, 16, 0, 1, 0, 0, 0, 101, 0, 0, 3, 242, 32, 16, 0, 0, 0, 0, 0, 104, 0, 0, 2, 2, 0, 0, 0, 
69, 0, 0, 9, 242, 0, 16, 0, 0, 0, 0, 0, 230, 26, 16, 0, 1, 0, 0, 0, 70, 126, 16, 0, 1, 0, 0, 0, 0, 96, 16, 0, 1, 0, 0, 0, 56, 0, 0, 7, 242, 0, 16, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 70, 30, 16, 0, 0, 0, 0, 0, 
69, 0, 0, 9, 242, 0, 16, 0, 1, 0, 0, 0, 70, 16, 16, 0, 1, 0, 0, 0, 70, 126, 16, 0, 0, 0, 0, 0, 0, 96, 16, 0, 0, 0, 0, 0, 56, 0, 0, 10, 242, 0, 16, 0, 1, 0, 0, 0, 70, 14, 16, 0, 1, 0, 0, 0, 2, 64, 0, 0, 0, 0, 0, 64, 
0, 0, 0, 64, 0, 0, 0, 64, 0, 0, 128, 63, 56, 0, 0, 7, 242, 32, 16, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 70, 14, 16, 0, 1, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 96, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 80, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 86, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
12, 12, 0, 0, 67, 79, 76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 79, 83, 71, 78, 44, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 83, 86, 95, 84, 
97, 114, 103, 101, 116, 0, 171, 171, 238, 95, 148, 196, 3, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 1, 1, 0, 3, 12, 0, 0, 0, 0, 0, 0, 0, 1, 
9, 83, 86, 95, 84, 97, 114, 103, 101, 116, 0, 0, 64, 3, 15, 0, 0, 0, 0, 0, 0, 0, 1, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 48, 3, 12, 68, 105, 102, 102, 117, 115, 101, 67, 111, 108, 111, 114, 1, 3, 0, 0, 16, 1, 4, 0, 8, 70, 111, 103, 67, 111, 108, 
111, 114, 1, 3, 16, 0, 12, 1, 3, 0, 9, 70, 111, 103, 86, 101, 99, 116, 111, 114, 1, 3, 32, 0, 16, 1, 4, 0, 5, 14, 84, 101, 120, 116, 117, 114, 101, 83, 97, 109, 112, 108, 101, 114, 4, 10, 0, 1, 15, 84, 101, 120, 116, 117, 114, 101, 50, 83, 97, 109, 112, 108, 101, 114, 
4, 10, 1, 1, 7, 84, 101, 120, 116, 117, 114, 101, 4, 7, 0, 1, 8, 84, 101, 120, 116, 117, 114, 101, 50, 4, 7, 1, 1, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 0, 0, 0, 0, 0, 0, 0, 145, 0, 0, 160, 9, 68, 88, 66, 67, 179, 110, 249, 65, 
153, 23, 225, 252, 42, 19, 47, 89, 17, 186, 167, 14, 1, 0, 0, 0, 160, 4, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 164, 1, 0, 0, 112, 3, 0, 0, 252, 3, 0, 0, 65, 111, 110, 57, 108, 1, 0, 0, 108, 1, 0, 0, 0, 2, 254, 255, 32, 1, 0, 0, 76, 0, 0, 0, 
3, 0, 36, 0, 0, 0, 72, 0, 0, 0, 72, 0, 0, 0, 36, 0, 1, 0, 72, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 4, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 254, 255, 
81, 0, 0, 5, 7, 0, 15, 160, 0, 0, 0, 0, 0, 0, 128, 63, 0, 0, 0, 0, 0, 0, 0, 0, 31, 0, 0, 2, 5, 0, 0, 128, 0, 0, 15, 144, 31, 0, 0, 2, 5, 0, 1, 128, 1, 0, 15, 144, 31, 0, 0, 2, 5, 0, 2, 128, 2, 0, 15, 144, 31, 0, 0, 2, 
5, 0, 3, 128, 3, 0, 15, 144, 9, 0, 0, 3, 0, 0, 1, 128, 0, 0, 228, 144, 2, 0, 228, 160, 11, 0, 0, 3, 0, 0, 1, 128, 0, 0, 0, 128, 7, 0, 0, 160, 10, 0, 0, 3, 1, 0, 8, 224, 0, 0, 0, 128, 7, 0, 85, 160, 5, 0, 0, 3, 0, 0, 15, 224, 
3, 0, 228, 144, 1, 0, 228, 160, 5, 0, 0, 3, 0, 0, 15, 128, 0, 0, 85, 144, 4, 0, 228, 160, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 0, 144, 3, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 170, 144, 5, 0, 228, 160, 0, 0, 228, 128, 
4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 255, 144, 6, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 3, 192, 0, 0, 255, 128, 0, 0, 228, 160, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 12, 192, 0, 0, 228, 128, 1, 0, 0, 2, 1, 0, 7, 224, 7, 0, 0, 160, 
1, 0, 0, 2, 2, 0, 3, 224, 1, 0, 228, 144, 1, 0, 0, 2, 2, 0, 12, 224, 2, 0, 20, 144, 255, 255, 0, 0, 83, 72, 68, 82, 196, 1, 0, 0, 64, 0, 1, 0, 113, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 0, 0, 0, 0, 3, 0, 0, 0, 89, 0, 0, 4, 
70, 142, 32, 0, 1, 0, 0, 0, 4, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 0, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 1, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 2, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 3, 0, 0, 0, 101, 0, 0, 3, 
242, 32, 16, 0, 0, 0, 0, 0, 101, 0, 0, 3, 242, 32, 16, 0, 1, 0, 0, 0, 101, 0, 0, 3, 50, 32, 16, 0, 2, 0, 0, 0, 101, 0, 0, 3, 194, 32, 16, 0, 2, 0, 0, 0, 103, 0, 0, 4, 242, 32, 16, 0, 3, 0, 0, 0, 1, 0, 0, 0, 104, 0, 0, 2, 
1, 0, 0, 0, 56, 0, 0, 8, 242, 32, 16, 0, 0, 0, 0, 0, 70, 30, 16, 0, 3, 0, 0, 0, 70, 142, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 17, 32, 0, 8, 130, 32, 16, 0, 1, 0, 0, 0, 70, 30, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 0, 0, 0, 0, 
2, 0, 0, 0, 54, 0, 0, 8, 114, 32, 16, 0, 1, 0, 0, 0, 2, 64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 54, 0, 0, 5, 50, 32, 16, 0, 2, 0, 0, 0, 70, 16, 16, 0, 1, 0, 0, 0, 54, 0, 0, 5, 194, 32, 16, 0, 
2, 0, 0, 0, 6, 20, 16, 0, 2, 0, 0, 0, 56, 0, 0, 8, 242, 0, 16, 0, 0, 0, 0, 0, 86, 21, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 1, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 6, 16, 16, 0, 0, 0, 0, 0, 
70, 142, 32, 0, 1, 0, 0, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 166, 26, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 2, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 
242, 32, 16, 0, 3, 0, 0, 0, 246, 31, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 3, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 132, 0, 0, 0, 4, 0, 0, 0, 8, 0, 0, 0, 104, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 116, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 116, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 
125, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 15, 15, 0, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 67, 79, 76, 79, 82, 0, 171, 79, 83, 71, 78, 156, 0, 0, 0, 5, 0, 0, 0, 
8, 0, 0, 0, 128, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 128, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 15, 0, 0, 0, 134, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
3, 0, 0, 0, 2, 0, 0, 0, 3, 12, 0, 0, 134, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 12, 3, 0, 0, 143, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 15, 0, 0, 0, 67, 79, 76, 79, 
82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 61, 252, 111, 133, 4, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 
8, 84, 69, 88, 67, 79, 79, 82, 68, 1, 2, 0, 3, 3, 0, 0, 5, 67, 79, 76, 79, 82, 0, 3, 0, 3, 15, 0, 0, 1, 176, 1, 68, 88, 66, 67, 231, 84, 81, 81, 132, 7, 222, 179, 176, 47, 126, 30, 49, 197, 136, 98, 1, 0, 0, 0, 176, 0, 0, 0, 1, 0, 0, 0, 
36, 0, 0, 0, 73, 83, 71, 78, 132, 0, 0, 0, 4, 0, 0, 0, 8, 0, 0, 0, 104, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 116, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
3, 3, 0, 0, 116, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 15, 15, 0, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 
84, 69, 88, 67, 79, 79, 82, 68, 0, 67, 79, 76, 79, 82, 0, 171, 59, 218, 25, 96, 5, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 5, 67, 79, 76, 79, 82, 1, 1, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 2, 0, 3, 3, 0, 0, 8, 
84, 69, 88, 67, 79, 79, 82, 68, 1, 2, 0, 3, 12, 0, 0, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 3, 1, 3, 15, 0, 0, 0, 0, 0, 0, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 48, 3, 12, 68, 105, 102, 102, 117, 115, 101, 67, 111, 108, 
111, 114, 1, 3, 0, 0, 16, 1, 4, 0, 8, 70, 111, 103, 67, 111, 108, 111, 114, 1, 3, 16, 0, 12, 1, 3, 0, 9, 70, 111, 103, 86, 101, 99, 116, 111, 114, 1, 3, 32, 0, 16, 1, 4, 0, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 64, 1, 
13, 87, 111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 2, 3, 0, 0, 64, 4, 4, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 4, 26, 1, 1, 0, 0, 0, 0, 0, 
0, 0, 145, 0, 0, 220, 7, 68, 88, 66, 67, 226, 68, 65, 164, 168, 109, 157, 209, 232, 242, 75, 69, 195, 216, 253, 118, 1, 0, 0, 0, 220, 3, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 68, 1, 0, 0, 196, 2, 0, 0, 80, 3, 0, 0, 65, 111, 110, 57, 12, 1, 0, 0, 12, 
1, 0, 0, 0, 2, 254, 255, 204, 0, 0, 0, 64, 0, 0, 0, 2, 0, 36, 0, 0, 0, 60, 0, 0, 0, 60, 0, 0, 0, 36, 0, 1, 0, 60, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 4, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
2, 254, 255, 31, 0, 0, 2, 5, 0, 0, 128, 0, 0, 15, 144, 31, 0, 0, 2, 5, 0, 1, 128, 1, 0, 15, 144, 31, 0, 0, 2, 5, 0, 2, 128, 2, 0, 15, 144, 31, 0, 0, 2, 5, 0, 3, 128, 3, 0, 15, 144, 5, 0, 0, 3, 0, 0, 15, 224, 3, 0, 228, 144, 1, 
0, 228, 160, 5, 0, 0, 3, 0, 0, 15, 128, 0, 0, 85, 144, 3, 0, 228, 160, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 0, 144, 2, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 0, 0, 170, 144, 4, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 
0, 15, 128, 0, 0, 255, 144, 5, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 3, 192, 0, 0, 255, 128, 0, 0, 228, 160, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 12, 192, 0, 0, 228, 128, 1, 0, 0, 2, 1, 0, 3, 224, 1, 0, 228, 144, 1, 0, 0, 2, 1, 
0, 12, 224, 2, 0, 20, 144, 255, 255, 0, 0, 83, 72, 68, 82, 120, 1, 0, 0, 64, 0, 1, 0, 94, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 0, 0, 0, 0, 1, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 1, 0, 0, 0, 4, 0, 0, 0, 95, 0, 0, 3, 242, 
16, 16, 0, 0, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 1, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 2, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 3, 0, 0, 0, 101, 0, 0, 3, 242, 32, 16, 0, 0, 0, 0, 0, 101, 0, 0, 3, 50, 32, 16, 0, 1, 
0, 0, 0, 101, 0, 0, 3, 194, 32, 16, 0, 1, 0, 0, 0, 103, 0, 0, 4, 242, 32, 16, 0, 2, 0, 0, 0, 1, 0, 0, 0, 104, 0, 0, 2, 1, 0, 0, 0, 56, 0, 0, 8, 242, 32, 16, 0, 0, 0, 0, 0, 70, 30, 16, 0, 3, 0, 0, 0, 70, 142, 32, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 54, 0, 0, 5, 50, 32, 16, 0, 1, 0, 0, 0, 70, 16, 16, 0, 1, 0, 0, 0, 54, 0, 0, 5, 194, 32, 16, 0, 1, 0, 0, 0, 6, 20, 16, 0, 2, 0, 0, 0, 56, 0, 0, 8, 242, 0, 16, 0, 0, 0, 0, 0, 86, 21, 16, 0, 0, 
0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 1, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 6, 16, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 
0, 0, 0, 166, 26, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 2, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 32, 16, 0, 2, 0, 0, 0, 246, 31, 16, 0, 0, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 3, 0, 0, 0, 70, 
14, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 132, 0, 0, 0, 4, 0, 0, 0, 8, 0, 0, 0, 104, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 116, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 
0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 116, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 15, 15, 0, 0, 83, 86, 95, 80, 111, 
115, 105, 116, 105, 111, 110, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 67, 79, 76, 79, 82, 0, 171, 79, 83, 71, 78, 132, 0, 0, 0, 4, 0, 0, 0, 8, 0, 0, 0, 104, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 110, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 12, 0, 0, 110, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 12, 3, 0, 0, 119, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 2, 
0, 0, 0, 15, 0, 0, 0, 67, 79, 76, 79, 82, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 152, 89, 155, 139, 4, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 
79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 1, 2, 0, 3, 3, 0, 0, 5, 67, 79, 76, 79, 82, 0, 3, 0, 3, 15, 0, 0, 1, 176, 1, 68, 88, 66, 67, 231, 84, 81, 81, 132, 7, 222, 179, 176, 47, 126, 30, 49, 197, 136, 98, 1, 
0, 0, 0, 176, 0, 0, 0, 1, 0, 0, 0, 36, 0, 0, 0, 73, 83, 71, 78, 132, 0, 0, 0, 4, 0, 0, 0, 8, 0, 0, 0, 104, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 116, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 3, 0, 0, 116, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 2, 0, 0, 0, 3, 3, 0, 0, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 15, 15, 0, 0, 83, 
86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 67, 79, 76, 79, 82, 0, 171, 59, 218, 25, 96, 4, 5, 67, 79, 76, 79, 82, 0, 0, 0, 3, 15, 0, 0, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 1, 0, 3, 3, 0, 0, 8, 84, 69, 
88, 67, 79, 79, 82, 68, 1, 1, 0, 3, 12, 0, 0, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 2, 1, 3, 15, 0, 0, 0, 0, 0, 0, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 48, 3, 12, 68, 105, 102, 102, 117, 115, 101, 67, 111, 108, 111, 114, 
1, 3, 0, 0, 16, 1, 4, 0, 8, 70, 111, 103, 67, 111, 108, 111, 114, 1, 3, 16, 0, 12, 1, 3, 0, 9, 70, 111, 103, 86, 101, 99, 116, 111, 114, 1, 3, 32, 0, 16, 1, 4, 0, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 64, 1, 13, 87, 
111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 2, 3, 0, 0, 64, 4, 4, 0, 2, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 4, 26, 1, 1, 69, 70, 70, 88, 121, 0, 0, 
0, 1, 26, 84, 111, 111, 108, 107, 105, 116, 58, 58, 68, 117, 97, 108, 84, 101, 120, 116, 117, 114, 101, 69, 102, 102, 101, 99, 116, 0, 1, 1, 17, 68, 117, 97, 108, 84, 101, 120, 116, 117, 114, 101, 69, 102, 102, 101, 99, 116, 5, 0, 0, 0, 1, 6, 0, 0, 0, 0, 0, 0, 0, 1, 
0, 1, 6, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 6, 1, 2, 0, 0, 0, 0, 1, 3, 0, 0, 0, 1, 0, 1, 6, 1, 4, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 6, 1, 5, 0, 0, 0, 0, 1, 3, 0, 0, 
        });
    }
}
