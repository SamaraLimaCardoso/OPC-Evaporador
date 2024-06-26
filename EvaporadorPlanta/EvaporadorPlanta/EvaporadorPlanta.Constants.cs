/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace EvaporadorPlanta
{
    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint Tanque1Type_TT003 = 36;

        /// <remarks />
        public const uint Tanque2Type_TT001 = 45;

        /// <remarks />
        public const uint Tanque2Type_TV001 = 53;

        /// <remarks />
        public const uint Tanque3Type_PT001 = 67;

        /// <remarks />
        public const uint Tanque3Type_LT001 = 75;

        /// <remarks />
        public const uint T1paraT2Type_SC001 = 84;

        /// <remarks />
        public const uint T1paraT3Type_SC003 = 92;

        /// <remarks />
        public const uint T2paraCxType_FV002 = 100;

        /// <remarks />
        public const uint T3paraCxType_FV001 = 114;

        /// <remarks />
        public const uint T3paraCxType_SC002 = 127;

        /// <remarks />
        public const uint T3paraCxType_TT002 = 134;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque1 = 143;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque1_TT003 = 144;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2 = 152;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TT001 = 153;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TV001 = 161;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3 = 174;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_PT001 = 175;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_LT001 = 183;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT2 = 191;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT2_SC001 = 192;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT3 = 199;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT3_SC003 = 200;

        /// <remarks />
        public const uint EvaporadorPlantaType_T2paraCx = 207;

        /// <remarks />
        public const uint EvaporadorPlantaType_T2paraCx_FV002 = 208;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx = 221;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_FV001 = 222;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_SC002 = 235;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_TT002 = 242;

        /// <remarks />
        public const uint PlantaEvaporador1 = 250;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque1 = 251;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque1_TT003 = 252;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2 = 260;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TT001 = 261;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TV001 = 269;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3 = 282;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_PT001 = 283;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_LT001 = 291;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT2 = 299;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT2_SC001 = 300;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT3 = 307;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT3_SC003 = 308;

        /// <remarks />
        public const uint PlantaEvaporador1_T2paraCx = 315;

        /// <remarks />
        public const uint PlantaEvaporador1_T2paraCx_FV002 = 316;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx = 329;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_FV001 = 330;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_SC002 = 343;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_TT002 = 350;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericoSensorType = 1;

        /// <remarks />
        public const uint GenericoAtuadorType = 9;

        /// <remarks />
        public const uint GenericoInvFreqType = 22;

        /// <remarks />
        public const uint IndicadorNivelType = 29;

        /// <remarks />
        public const uint IndicadorTempType = 30;

        /// <remarks />
        public const uint MedidorPressaoType = 31;

        /// <remarks />
        public const uint ValvulaType = 32;

        /// <remarks />
        public const uint ResistenciaType = 33;

        /// <remarks />
        public const uint InvMotorType = 34;

        /// <remarks />
        public const uint Tanque1Type = 35;

        /// <remarks />
        public const uint Tanque2Type = 44;

        /// <remarks />
        public const uint Tanque3Type = 66;

        /// <remarks />
        public const uint T1paraT2Type = 83;

        /// <remarks />
        public const uint T1paraT3Type = 91;

        /// <remarks />
        public const uint T2paraCxType = 99;

        /// <remarks />
        public const uint T3paraCxType = 113;

        /// <remarks />
        public const uint EvaporadorPlantaType = 142;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericoSensorType_Output = 2;

        /// <remarks />
        public const uint GenericoSensorType_Output_EURange = 6;

        /// <remarks />
        public const uint GenericoSensorType_Unidade = 8;

        /// <remarks />
        public const uint GenericoAtuadorType_Input = 10;

        /// <remarks />
        public const uint GenericoAtuadorType_Input_EURange = 14;

        /// <remarks />
        public const uint GenericoAtuadorType_Output = 16;

        /// <remarks />
        public const uint GenericoAtuadorType_Output_EURange = 20;

        /// <remarks />
        public const uint GenericoInvFreqType_pwm = 23;

        /// <remarks />
        public const uint GenericoInvFreqType_pwm_EURange = 27;

        /// <remarks />
        public const uint Tanque1Type_TT003_Output = 37;

        /// <remarks />
        public const uint Tanque1Type_TT003_Output_EURange = 41;

        /// <remarks />
        public const uint Tanque1Type_TT003_Unidade = 43;

        /// <remarks />
        public const uint Tanque2Type_TT001_Output = 46;

        /// <remarks />
        public const uint Tanque2Type_TT001_Output_EURange = 50;

        /// <remarks />
        public const uint Tanque2Type_TT001_Unidade = 52;

        /// <remarks />
        public const uint Tanque2Type_TV001_Input = 54;

        /// <remarks />
        public const uint Tanque2Type_TV001_Input_EURange = 58;

        /// <remarks />
        public const uint Tanque2Type_TV001_Output = 60;

        /// <remarks />
        public const uint Tanque2Type_TV001_Output_EURange = 64;

        /// <remarks />
        public const uint Tanque3Type_PT001_Output = 68;

        /// <remarks />
        public const uint Tanque3Type_PT001_Output_EURange = 72;

        /// <remarks />
        public const uint Tanque3Type_PT001_Unidade = 74;

        /// <remarks />
        public const uint Tanque3Type_LT001_Output = 76;

        /// <remarks />
        public const uint Tanque3Type_LT001_Output_EURange = 80;

        /// <remarks />
        public const uint Tanque3Type_LT001_Unidade = 82;

        /// <remarks />
        public const uint T1paraT2Type_SC001_pwm = 85;

        /// <remarks />
        public const uint T1paraT2Type_SC001_pwm_EURange = 89;

        /// <remarks />
        public const uint T1paraT3Type_SC003_pwm = 93;

        /// <remarks />
        public const uint T1paraT3Type_SC003_pwm_EURange = 97;

        /// <remarks />
        public const uint T2paraCxType_FV002_Input = 101;

        /// <remarks />
        public const uint T2paraCxType_FV002_Input_EURange = 105;

        /// <remarks />
        public const uint T2paraCxType_FV002_Output = 107;

        /// <remarks />
        public const uint T2paraCxType_FV002_Output_EURange = 111;

        /// <remarks />
        public const uint T3paraCxType_FV001_Input = 115;

        /// <remarks />
        public const uint T3paraCxType_FV001_Input_EURange = 119;

        /// <remarks />
        public const uint T3paraCxType_FV001_Output = 121;

        /// <remarks />
        public const uint T3paraCxType_FV001_Output_EURange = 125;

        /// <remarks />
        public const uint T3paraCxType_SC002_pwm = 128;

        /// <remarks />
        public const uint T3paraCxType_SC002_pwm_EURange = 132;

        /// <remarks />
        public const uint T3paraCxType_TT002_Output = 135;

        /// <remarks />
        public const uint T3paraCxType_TT002_Output_EURange = 139;

        /// <remarks />
        public const uint T3paraCxType_TT002_Unidade = 141;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque1_TT003_Output = 145;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque1_TT003_Output_EURange = 149;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque1_TT003_Unidade = 151;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TT001_Output = 154;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TT001_Output_EURange = 158;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TT001_Unidade = 160;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TV001_Input = 162;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TV001_Input_EURange = 166;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TV001_Output = 168;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque2_TV001_Output_EURange = 172;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_PT001_Output = 176;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_PT001_Output_EURange = 180;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_PT001_Unidade = 182;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_LT001_Output = 184;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_LT001_Output_EURange = 188;

        /// <remarks />
        public const uint EvaporadorPlantaType_Tanque3_LT001_Unidade = 190;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT2_SC001_pwm = 193;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT2_SC001_pwm_EURange = 197;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT3_SC003_pwm = 201;

        /// <remarks />
        public const uint EvaporadorPlantaType_T1paraT3_SC003_pwm_EURange = 205;

        /// <remarks />
        public const uint EvaporadorPlantaType_T2paraCx_FV002_Input = 209;

        /// <remarks />
        public const uint EvaporadorPlantaType_T2paraCx_FV002_Input_EURange = 213;

        /// <remarks />
        public const uint EvaporadorPlantaType_T2paraCx_FV002_Output = 215;

        /// <remarks />
        public const uint EvaporadorPlantaType_T2paraCx_FV002_Output_EURange = 219;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_FV001_Input = 223;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_FV001_Input_EURange = 227;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_FV001_Output = 229;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_FV001_Output_EURange = 233;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_SC002_pwm = 236;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_SC002_pwm_EURange = 240;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_TT002_Output = 243;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_TT002_Output_EURange = 247;

        /// <remarks />
        public const uint EvaporadorPlantaType_T3paraCx_TT002_Unidade = 249;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque1_TT003_Output = 253;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque1_TT003_Output_EURange = 257;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque1_TT003_Unidade = 259;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TT001_Output = 262;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TT001_Output_EURange = 266;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TT001_Unidade = 268;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TV001_Input = 270;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TV001_Input_EURange = 274;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TV001_Output = 276;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque2_TV001_Output_EURange = 280;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_PT001_Output = 284;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_PT001_Output_EURange = 288;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_PT001_Unidade = 290;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_LT001_Output = 292;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_LT001_Output_EURange = 296;

        /// <remarks />
        public const uint PlantaEvaporador1_Tanque3_LT001_Unidade = 298;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT2_SC001_pwm = 301;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT2_SC001_pwm_EURange = 305;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT3_SC003_pwm = 309;

        /// <remarks />
        public const uint PlantaEvaporador1_T1paraT3_SC003_pwm_EURange = 313;

        /// <remarks />
        public const uint PlantaEvaporador1_T2paraCx_FV002_Input = 317;

        /// <remarks />
        public const uint PlantaEvaporador1_T2paraCx_FV002_Input_EURange = 321;

        /// <remarks />
        public const uint PlantaEvaporador1_T2paraCx_FV002_Output = 323;

        /// <remarks />
        public const uint PlantaEvaporador1_T2paraCx_FV002_Output_EURange = 327;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_FV001_Input = 331;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_FV001_Input_EURange = 335;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_FV001_Output = 337;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_FV001_Output_EURange = 341;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_SC002_pwm = 344;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_SC002_pwm_EURange = 348;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_TT002_Output = 351;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_TT002_Output_EURange = 355;

        /// <remarks />
        public const uint PlantaEvaporador1_T3paraCx_TT002_Unidade = 357;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Tanque1Type_TT003 = new ExpandedNodeId(EvaporadorPlanta.Objects.Tanque1Type_TT003, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.Tanque2Type_TT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TV001 = new ExpandedNodeId(EvaporadorPlanta.Objects.Tanque2Type_TV001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_PT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.Tanque3Type_PT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_LT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.Tanque3Type_LT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT2Type_SC001 = new ExpandedNodeId(EvaporadorPlanta.Objects.T1paraT2Type_SC001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT3Type_SC003 = new ExpandedNodeId(EvaporadorPlanta.Objects.T1paraT3Type_SC003, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T2paraCxType_FV002 = new ExpandedNodeId(EvaporadorPlanta.Objects.T2paraCxType_FV002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_FV001 = new ExpandedNodeId(EvaporadorPlanta.Objects.T3paraCxType_FV001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_SC002 = new ExpandedNodeId(EvaporadorPlanta.Objects.T3paraCxType_SC002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_TT002 = new ExpandedNodeId(EvaporadorPlanta.Objects.T3paraCxType_TT002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque1 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque1, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque1_TT003 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque1_TT003, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque2, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque2_TT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TV001 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque2_TV001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque3, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_PT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque3_PT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_LT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_Tanque3_LT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT2 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T1paraT2, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT2_SC001 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T1paraT2_SC001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT3 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T1paraT3, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT3_SC003 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T1paraT3_SC003, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T2paraCx = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T2paraCx, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T2paraCx_FV002 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T2paraCx_FV002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T3paraCx, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_FV001 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T3paraCx_FV001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_SC002 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T3paraCx_SC002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_TT002 = new ExpandedNodeId(EvaporadorPlanta.Objects.EvaporadorPlantaType_T3paraCx_TT002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque1 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque1, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque1_TT003 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque1_TT003, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque2, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque2_TT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TV001 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque2_TV001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque3, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_PT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque3_PT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_LT001 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_Tanque3_LT001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT2 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T1paraT2, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT2_SC001 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T1paraT2_SC001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT3 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T1paraT3, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT3_SC003 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T1paraT3_SC003, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T2paraCx = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T2paraCx, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T2paraCx_FV002 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T2paraCx_FV002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T3paraCx, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_FV001 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T3paraCx_FV001, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_SC002 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T3paraCx_SC002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_TT002 = new ExpandedNodeId(EvaporadorPlanta.Objects.PlantaEvaporador1_T3paraCx_TT002, EvaporadorPlanta.Namespaces.EvaporadorPlanta);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericoSensorType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.GenericoSensorType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoAtuadorType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.GenericoAtuadorType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoInvFreqType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.GenericoInvFreqType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId IndicadorNivelType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.IndicadorNivelType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId IndicadorTempType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.IndicadorTempType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId MedidorPressaoType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.MedidorPressaoType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId ValvulaType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.ValvulaType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId ResistenciaType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.ResistenciaType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId InvMotorType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.InvMotorType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1Type = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.Tanque1Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.Tanque2Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.Tanque3Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT2Type = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.T1paraT2Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT3Type = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.T1paraT3Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T2paraCxType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.T2paraCxType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.T3paraCxType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType = new ExpandedNodeId(EvaporadorPlanta.ObjectTypes.EvaporadorPlantaType, EvaporadorPlanta.Namespaces.EvaporadorPlanta);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericoSensorType_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoSensorType_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoSensorType_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoSensorType_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoSensorType_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoSensorType_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoAtuadorType_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoAtuadorType_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoAtuadorType_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoAtuadorType_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoAtuadorType_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoAtuadorType_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoAtuadorType_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoAtuadorType_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoInvFreqType_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoInvFreqType_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId GenericoInvFreqType_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.GenericoInvFreqType_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1Type_TT003_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque1Type_TT003_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1Type_TT003_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque1Type_TT003_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque1Type_TT003_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque1Type_TT003_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque2Type_TT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque2Type_TT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque2Type_TT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TV001_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque2Type_TV001_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TV001_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque2Type_TV001_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TV001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque2Type_TV001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque2Type_TV001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque2Type_TV001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_PT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque3Type_PT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_PT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque3Type_PT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_PT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque3Type_PT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_LT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque3Type_LT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_LT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque3Type_LT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId Tanque3Type_LT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.Tanque3Type_LT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT2Type_SC001_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.T1paraT2Type_SC001_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT2Type_SC001_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T1paraT2Type_SC001_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT3Type_SC003_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.T1paraT3Type_SC003_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T1paraT3Type_SC003_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T1paraT3Type_SC003_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T2paraCxType_FV002_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.T2paraCxType_FV002_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T2paraCxType_FV002_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T2paraCxType_FV002_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T2paraCxType_FV002_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.T2paraCxType_FV002_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T2paraCxType_FV002_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T2paraCxType_FV002_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_FV001_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_FV001_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_FV001_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_FV001_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_FV001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_FV001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_FV001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_FV001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_SC002_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_SC002_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_SC002_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_SC002_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_TT002_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_TT002_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_TT002_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_TT002_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId T3paraCxType_TT002_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.T3paraCxType_TT002_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque1_TT003_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque1_TT003_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque1_TT003_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque1_TT003_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque1_TT003_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque1_TT003_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque2_TT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque2_TT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque2_TT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TV001_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque2_TV001_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TV001_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque2_TV001_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TV001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque2_TV001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque2_TV001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque2_TV001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_PT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque3_PT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_PT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque3_PT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_PT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque3_PT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_LT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque3_LT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_LT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque3_LT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_Tanque3_LT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_Tanque3_LT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT2_SC001_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T1paraT2_SC001_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT2_SC001_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T1paraT2_SC001_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT3_SC003_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T1paraT3_SC003_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T1paraT3_SC003_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T1paraT3_SC003_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T2paraCx_FV002_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T2paraCx_FV002_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T2paraCx_FV002_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T2paraCx_FV002_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T2paraCx_FV002_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T2paraCx_FV002_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T2paraCx_FV002_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T2paraCx_FV002_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_FV001_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_FV001_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_FV001_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_FV001_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_FV001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_FV001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_FV001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_FV001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_SC002_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_SC002_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_SC002_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_SC002_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_TT002_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_TT002_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_TT002_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_TT002_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId EvaporadorPlantaType_T3paraCx_TT002_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.EvaporadorPlantaType_T3paraCx_TT002_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque1_TT003_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque1_TT003_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque1_TT003_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque1_TT003_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque1_TT003_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque1_TT003_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque2_TT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque2_TT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque2_TT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TV001_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque2_TV001_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TV001_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque2_TV001_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TV001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque2_TV001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque2_TV001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque2_TV001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_PT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque3_PT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_PT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque3_PT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_PT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque3_PT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_LT001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque3_LT001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_LT001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque3_LT001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_Tanque3_LT001_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_Tanque3_LT001_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT2_SC001_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T1paraT2_SC001_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT2_SC001_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T1paraT2_SC001_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT3_SC003_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T1paraT3_SC003_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T1paraT3_SC003_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T1paraT3_SC003_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T2paraCx_FV002_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T2paraCx_FV002_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T2paraCx_FV002_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T2paraCx_FV002_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T2paraCx_FV002_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T2paraCx_FV002_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T2paraCx_FV002_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T2paraCx_FV002_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_FV001_Input = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_FV001_Input, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_FV001_Input_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_FV001_Input_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_FV001_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_FV001_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_FV001_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_FV001_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_SC002_pwm = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_SC002_pwm, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_SC002_pwm_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_SC002_pwm_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_TT002_Output = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_TT002_Output, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_TT002_Output_EURange = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_TT002_Output_EURange, EvaporadorPlanta.Namespaces.EvaporadorPlanta);

        /// <remarks />
        public static readonly ExpandedNodeId PlantaEvaporador1_T3paraCx_TT002_Unidade = new ExpandedNodeId(EvaporadorPlanta.Variables.PlantaEvaporador1_T3paraCx_TT002_Unidade, EvaporadorPlanta.Namespaces.EvaporadorPlanta);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string EvaporadorPlantaType = "EvaporadorPlantaType";

        /// <remarks />
        public const string FV001 = "FV001";

        /// <remarks />
        public const string FV002 = "FV002";

        /// <remarks />
        public const string GenericoAtuadorType = "GenericoAtuadorType";

        /// <remarks />
        public const string GenericoInvFreqType = "GenericoInvFreqType";

        /// <remarks />
        public const string GenericoSensorType = "GenericoSensorType";

        /// <remarks />
        public const string IndicadorNivelType = "IndicadorNivelType";

        /// <remarks />
        public const string IndicadorTempType = "IndicadorTempType";

        /// <remarks />
        public const string Input = "Input";

        /// <remarks />
        public const string InvMotorType = "InvMotorType";

        /// <remarks />
        public const string LT001 = "LT001";

        /// <remarks />
        public const string MedidorPressaoType = "MedidorPressaoType";

        /// <remarks />
        public const string Output = "Output";

        /// <remarks />
        public const string PlantaEvaporador1 = "Planta Evaporador #1";

        /// <remarks />
        public const string PT001 = "PT001";

        /// <remarks />
        public const string pwm = "pwm";

        /// <remarks />
        public const string ResistenciaType = "ResistenciaType";

        /// <remarks />
        public const string SC001 = "SC001";

        /// <remarks />
        public const string SC002 = "SC002";

        /// <remarks />
        public const string SC003 = "SC003";

        /// <remarks />
        public const string T1paraT2 = "T1paraT2X001";

        /// <remarks />
        public const string T1paraT2Type = "T1paraT2Type";

        /// <remarks />
        public const string T1paraT3 = "T1paraT3X001";

        /// <remarks />
        public const string T1paraT3Type = "T1paraT3Type";

        /// <remarks />
        public const string T2paraCx = "T2paraCxX001";

        /// <remarks />
        public const string T2paraCxType = "T2paraCxType";

        /// <remarks />
        public const string T3paraCx = "T3paraCxX001";

        /// <remarks />
        public const string T3paraCxType = "T3paraCxType";

        /// <remarks />
        public const string Tanque1 = "Tanque001";

        /// <remarks />
        public const string Tanque1Type = "Tanque1Type";

        /// <remarks />
        public const string Tanque2 = "Tanque002";

        /// <remarks />
        public const string Tanque2Type = "Tanque2Type";

        /// <remarks />
        public const string Tanque3 = "Tanque003";

        /// <remarks />
        public const string Tanque3Type = "Tanque3Type";

        /// <remarks />
        public const string TT001 = "TT001";

        /// <remarks />
        public const string TT002 = "TT002";

        /// <remarks />
        public const string TT003 = "TT003";

        /// <remarks />
        public const string TV001 = "TV001";

        /// <remarks />
        public const string Unidade = "Unidade";

        /// <remarks />
        public const string ValvulaType = "ValvulaType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the EvaporadorPlanta namespace (.NET code namespace is 'EvaporadorPlanta').
        /// </summary>
        public const string EvaporadorPlanta = "http://opcfoundation.org/EvaporadorPlanta";
    }
    #endregion
}