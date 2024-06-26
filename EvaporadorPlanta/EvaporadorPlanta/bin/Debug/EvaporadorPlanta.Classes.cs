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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace EvaporadorPlanta
{
    #region GenericoSensorState Class
    #if (!OPCUA_EXCLUDE_GenericoSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericoSensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericoSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.GenericoSensorType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAGgAAAEdlbmVyaWNvU2Vuc29yVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wIAAAAVYIkKAgAA" +
           "AAEABgAAAE91dHB1dAEBAgAALwEAQAkCAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBBgAALgBEBgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAAVW5pZGFkZQEBCAAA" +
           "LgBECAAAAAAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Unidade
        {
            get
            {
                return m_unidade;
            }

            set
            {
                if (!Object.ReferenceEquals(m_unidade, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_unidade = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_unidade != null)
            {
                children.Add(m_unidade);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.Unidade:
                {
                    if (createOrReplace)
                    {
                        if (Unidade == null)
                        {
                            if (replacement == null)
                            {
                                Unidade = new PropertyState<string>(this);
                            }
                            else
                            {
                                Unidade = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Unidade;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_output;
        private PropertyState<string> m_unidade;
        #endregion
    }
    #endif
    #endregion

    #region GenericoAtuadorState Class
    #if (!OPCUA_EXCLUDE_GenericoAtuadorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericoAtuadorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericoAtuadorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.GenericoAtuadorType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAGwAAAEdlbmVyaWNvQXR1YWRvclR5cGVJbnN0YW5jZQEBCQABAQkACQAAAP////8CAAAAFWCJCgIA" +
           "AAABAAUAAABJbnB1dAEBCgAALwEAQAkKAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBDgAALgBEDgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQEQAAAv" +
           "AQBACRAAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEUAAAuAEQUAAAAAQB0" +
           "A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            if (m_output != null)
            {
                children.Add(m_output);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_input;
        private AnalogItemState<double> m_output;
        #endregion
    }
    #endif
    #endregion

    #region GenericoInvFreqState Class
    #if (!OPCUA_EXCLUDE_GenericoInvFreqState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericoInvFreqState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericoInvFreqState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.GenericoInvFreqType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAGwAAAEdlbmVyaWNvSW52RnJlcVR5cGVJbnN0YW5jZQEBFgABARYAFgAAAP////8BAAAAFWCJCgIA" +
           "AAABAAMAAABwd20BARcAAC8BAEAJFwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UBARsAAC4ARBsAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> pwm
        {
            get
            {
                return m_pwm;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pwm, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pwm = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pwm != null)
            {
                children.Add(m_pwm);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.pwm:
                {
                    if (createOrReplace)
                    {
                        if (pwm == null)
                        {
                            if (replacement == null)
                            {
                                pwm = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                pwm = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = pwm;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_pwm;
        #endregion
    }
    #endif
    #endregion

    #region IndicadorNivelState Class
    #if (!OPCUA_EXCLUDE_IndicadorNivelState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IndicadorNivelState : GenericoSensorState
    {
        #region Constructors
        /// <remarks />
        public IndicadorNivelState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.IndicadorNivelType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAGgAAAEluZGljYWRvck5pdmVsVHlwZUluc3RhbmNlAQEdAAEBHQAdAAAA/////wIAAAAVYIkKAgAA" +
           "AAEABgAAAE91dHB1dAIBAEFCDwAALwEAQAlBQg8AAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQIBAEVCDwAALgBERUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAAVW5pZGFk" +
           "ZQIBAEdCDwAALgBER0IPAAAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region IndicadorTempState Class
    #if (!OPCUA_EXCLUDE_IndicadorTempState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IndicadorTempState : GenericoSensorState
    {
        #region Constructors
        /// <remarks />
        public IndicadorTempState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.IndicadorTempType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAGQAAAEluZGljYWRvclRlbXBUeXBlSW5zdGFuY2UBAR4AAQEeAB4AAAD/////AgAAABVgiQoCAAAA" +
           "AQAGAAAAT3V0cHV0AgEASEIPAAAvAQBACUhCDwAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAgEATEIPAAAuAERMQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABVbmlkYWRl" +
           "AgEATkIPAAAuAEROQg8AAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MedidorPressaoState Class
    #if (!OPCUA_EXCLUDE_MedidorPressaoState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MedidorPressaoState : GenericoSensorState
    {
        #region Constructors
        /// <remarks />
        public MedidorPressaoState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.MedidorPressaoType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAGgAAAE1lZGlkb3JQcmVzc2FvVHlwZUluc3RhbmNlAQEfAAEBHwAfAAAA/////wIAAAAVYIkKAgAA" +
           "AAEABgAAAE91dHB1dAIBAE9CDwAALwEAQAlPQg8AAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQIBAFNCDwAALgBEU0IPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAAVW5pZGFk" +
           "ZQIBAFVCDwAALgBEVUIPAAAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ValvulaState Class
    #if (!OPCUA_EXCLUDE_ValvulaState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValvulaState : GenericoAtuadorState
    {
        #region Constructors
        /// <remarks />
        public ValvulaState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.ValvulaType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAEwAAAFZhbHZ1bGFUeXBlSW5zdGFuY2UBASAAAQEgACAAAAD/////AgAAABVgiQoCAAAAAQAFAAAA" +
           "SW5wdXQCAQBWQg8AAC8BAEAJVkIPAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UC" +
           "AQBaQg8AAC4ARFpCDwABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAIBAFxCDwAA" +
           "LwEAQAlcQg8AAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQIBAGBCDwAALgBEYEIP" +
           "AAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ResistenciaState Class
    #if (!OPCUA_EXCLUDE_ResistenciaState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResistenciaState : GenericoAtuadorState
    {
        #region Constructors
        /// <remarks />
        public ResistenciaState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.ResistenciaType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAFwAAAFJlc2lzdGVuY2lhVHlwZUluc3RhbmNlAQEhAAEBIQAhAAAA/////wIAAAAVYIkKAgAAAAEA" +
           "BQAAAElucHV0AgEAYkIPAAAvAQBACWJCDwAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAgEAZkIPAAAuAERmQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQCAQBo" +
           "Qg8AAC8BAEAJaEIPAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UCAQBsQg8AAC4A" +
           "RGxCDwABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region InvMotorState Class
    #if (!OPCUA_EXCLUDE_InvMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InvMotorState : GenericoInvFreqState
    {
        #region Constructors
        /// <remarks />
        public InvMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.InvMotorType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAFAAAAEludk1vdG9yVHlwZUluc3RhbmNlAQEiAAEBIgAiAAAA/////wEAAAAVYIkKAgAAAAEAAwAA" +
           "AHB3bQIBAG5CDwAALwEAQAluQg8AAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQIB" +
           "AHJCDwAALgBEckIPAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Tanque1State Class
    #if (!OPCUA_EXCLUDE_Tanque1State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Tanque1State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Tanque1State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.Tanque1Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAEwAAAFRhbnF1ZTFUeXBlSW5zdGFuY2UBASMAAQEjACMAAAABAAAAADAAAQEkAAEAAACEYIAKAQAA" +
           "AAEABQAAAFRUMDAzAQEkAAAvAQEeACQAAAABAQAAAAAwAQEBIwACAAAAFWCJCgIAAAABAAYAAABPdXRw" +
           "dXQBASUAAC8BAEAJJQAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBASkAAC4A" +
           "RCkAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAFVuaWRhZGUBASsAAC4ARCsAAAAADP//" +
           "//8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public IndicadorTempState TT003
        {
            get
            {
                return m_tT003;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tT003, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tT003 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tT003 != null)
            {
                children.Add(m_tT003);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.TT003:
                {
                    if (createOrReplace)
                    {
                        if (TT003 == null)
                        {
                            if (replacement == null)
                            {
                                TT003 = new IndicadorTempState(this);
                            }
                            else
                            {
                                TT003 = (IndicadorTempState)replacement;
                            }
                        }
                    }

                    instance = TT003;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private IndicadorTempState m_tT003;
        #endregion
    }
    #endif
    #endregion

    #region Tanque2State Class
    #if (!OPCUA_EXCLUDE_Tanque2State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Tanque2State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Tanque2State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.Tanque2Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAEwAAAFRhbnF1ZTJUeXBlSW5zdGFuY2UBASwAAQEsACwAAAABAAAAADAAAQEtAAIAAACEYIAKAQAA" +
           "AAEABQAAAFRUMDAxAQEtAAAvAQEeAC0AAAABAQAAAAAwAQEBLAACAAAAFWCJCgIAAAABAAYAAABPdXRw" +
           "dXQBAS4AAC8BAEAJLgAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBATIAAC4A" +
           "RDIAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAFVuaWRhZGUBATQAAC4ARDQAAAAADP//" +
           "//8DA/////8AAAAAhGCACgEAAAABAAUAAABUVjAwMQEBNQAALwEBIQA1AAAAAf////8CAAAAFWCJCgIA" +
           "AAABAAUAAABJbnB1dAEBNgAALwEAQAk2AAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBOgAALgBEOgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQE8AAAv" +
           "AQBACTwAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFAAAAuAERAAAAAAQB0" +
           "A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public IndicadorTempState TT001
        {
            get
            {
                return m_tT001;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tT001, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tT001 = value;
            }
        }

        /// <remarks />
        public ResistenciaState TV001
        {
            get
            {
                return m_tV001;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tV001, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tV001 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tT001 != null)
            {
                children.Add(m_tT001);
            }

            if (m_tV001 != null)
            {
                children.Add(m_tV001);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.TT001:
                {
                    if (createOrReplace)
                    {
                        if (TT001 == null)
                        {
                            if (replacement == null)
                            {
                                TT001 = new IndicadorTempState(this);
                            }
                            else
                            {
                                TT001 = (IndicadorTempState)replacement;
                            }
                        }
                    }

                    instance = TT001;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.TV001:
                {
                    if (createOrReplace)
                    {
                        if (TV001 == null)
                        {
                            if (replacement == null)
                            {
                                TV001 = new ResistenciaState(this);
                            }
                            else
                            {
                                TV001 = (ResistenciaState)replacement;
                            }
                        }
                    }

                    instance = TV001;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private IndicadorTempState m_tT001;
        private ResistenciaState m_tV001;
        #endregion
    }
    #endif
    #endregion

    #region Tanque3State Class
    #if (!OPCUA_EXCLUDE_Tanque3State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Tanque3State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Tanque3State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.Tanque3Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAEwAAAFRhbnF1ZTNUeXBlSW5zdGFuY2UBAUIAAQFCAEIAAAABAAAAADAAAQFLAAIAAACEYIAKAQAA" +
           "AAEABQAAAFBUMDAxAQFDAAAvAQEfAEMAAAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBRAAA" +
           "LwEAQAlEAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBSAAALgBESAAAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAAVW5pZGFkZQEBSgAALgBESgAAAAAM/////wMD////" +
           "/wAAAACEYIAKAQAAAAEABQAAAExUMDAxAQFLAAAvAQEdAEsAAAABAQAAAAAwAQEBQgACAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAUwAAC8BAEAJTAAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAVAAAC4ARFAAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAFVuaWRhZGUBAVIA" +
           "AC4ARFIAAAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MedidorPressaoState PT001
        {
            get
            {
                return m_pT001;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pT001, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pT001 = value;
            }
        }

        /// <remarks />
        public IndicadorNivelState LT001
        {
            get
            {
                return m_lT001;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lT001, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lT001 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pT001 != null)
            {
                children.Add(m_pT001);
            }

            if (m_lT001 != null)
            {
                children.Add(m_lT001);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.PT001:
                {
                    if (createOrReplace)
                    {
                        if (PT001 == null)
                        {
                            if (replacement == null)
                            {
                                PT001 = new MedidorPressaoState(this);
                            }
                            else
                            {
                                PT001 = (MedidorPressaoState)replacement;
                            }
                        }
                    }

                    instance = PT001;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.LT001:
                {
                    if (createOrReplace)
                    {
                        if (LT001 == null)
                        {
                            if (replacement == null)
                            {
                                LT001 = new IndicadorNivelState(this);
                            }
                            else
                            {
                                LT001 = (IndicadorNivelState)replacement;
                            }
                        }
                    }

                    instance = LT001;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MedidorPressaoState m_pT001;
        private IndicadorNivelState m_lT001;
        #endregion
    }
    #endif
    #endregion

    #region T1paraT2State Class
    #if (!OPCUA_EXCLUDE_T1paraT2State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class T1paraT2State : FolderState
    {
        #region Constructors
        /// <remarks />
        public T1paraT2State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.T1paraT2Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAFAAAAFQxcGFyYVQyVHlwZUluc3RhbmNlAQFTAAEBUwBTAAAAAQAAAAAwAAEBVAABAAAAhGCACgEA" +
           "AAABAAUAAABTQzAwMQEBVAAALwEBIgBUAAAAAQEAAAAAMAEBAVMAAQAAABVgiQoCAAAAAQADAAAAcHdt" +
           "AQFVAAAvAQBACVUAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFZAAAuAERZ" +
           "AAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public InvMotorState SC001
        {
            get
            {
                return m_sC001;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sC001, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sC001 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_sC001 != null)
            {
                children.Add(m_sC001);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.SC001:
                {
                    if (createOrReplace)
                    {
                        if (SC001 == null)
                        {
                            if (replacement == null)
                            {
                                SC001 = new InvMotorState(this);
                            }
                            else
                            {
                                SC001 = (InvMotorState)replacement;
                            }
                        }
                    }

                    instance = SC001;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private InvMotorState m_sC001;
        #endregion
    }
    #endif
    #endregion

    #region T1paraT3State Class
    #if (!OPCUA_EXCLUDE_T1paraT3State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class T1paraT3State : FolderState
    {
        #region Constructors
        /// <remarks />
        public T1paraT3State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.T1paraT3Type, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAFAAAAFQxcGFyYVQzVHlwZUluc3RhbmNlAQFbAAEBWwBbAAAAAQAAAAAwAAEBXAABAAAAhGCACgEA" +
           "AAABAAUAAABTQzAwMwEBXAAALwEBIgBcAAAAAQEAAAAAMAEBAVsAAQAAABVgiQoCAAAAAQADAAAAcHdt" +
           "AQFdAAAvAQBACV0AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFhAAAuAERh" +
           "AAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public InvMotorState SC003
        {
            get
            {
                return m_sC003;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sC003, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sC003 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_sC003 != null)
            {
                children.Add(m_sC003);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.SC003:
                {
                    if (createOrReplace)
                    {
                        if (SC003 == null)
                        {
                            if (replacement == null)
                            {
                                SC003 = new InvMotorState(this);
                            }
                            else
                            {
                                SC003 = (InvMotorState)replacement;
                            }
                        }
                    }

                    instance = SC003;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private InvMotorState m_sC003;
        #endregion
    }
    #endif
    #endregion

    #region T2paraCxState Class
    #if (!OPCUA_EXCLUDE_T2paraCxState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class T2paraCxState : FolderState
    {
        #region Constructors
        /// <remarks />
        public T2paraCxState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.T2paraCxType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAFAAAAFQycGFyYUN4VHlwZUluc3RhbmNlAQFjAAEBYwBjAAAAAQAAAAAwAAEBZAABAAAAhGCACgEA" +
           "AAABAAUAAABGVjAwMgEBZAAALwEBIABkAAAAAQEAAAAAMAEBAWMAAgAAABVgiQoCAAAAAQAFAAAASW5w" +
           "dXQBAWUAAC8BAEAJZQAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAWkAAC4A" +
           "RGkAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBawAALwEAQAlrAAAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBbwAALgBEbwAAAAEAdAP/////AQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ValvulaState FV002
        {
            get
            {
                return m_fV002;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fV002, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fV002 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_fV002 != null)
            {
                children.Add(m_fV002);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.FV002:
                {
                    if (createOrReplace)
                    {
                        if (FV002 == null)
                        {
                            if (replacement == null)
                            {
                                FV002 = new ValvulaState(this);
                            }
                            else
                            {
                                FV002 = (ValvulaState)replacement;
                            }
                        }
                    }

                    instance = FV002;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ValvulaState m_fV002;
        #endregion
    }
    #endif
    #endregion

    #region T3paraCxState Class
    #if (!OPCUA_EXCLUDE_T3paraCxState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class T3paraCxState : FolderState
    {
        #region Constructors
        /// <remarks />
        public T3paraCxState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.T3paraCxType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////8EYIACAQAA" +
           "AAEAFAAAAFQzcGFyYUN4VHlwZUluc3RhbmNlAQFxAAEBcQBxAAAAAQAAAAAwAAEBcgADAAAAhGCACgEA" +
           "AAABAAUAAABGVjAwMQEBcgAALwEBIAByAAAAAQEAAAAAMAEBAXEAAgAAABVgiQoCAAAAAQAFAAAASW5w" +
           "dXQBAXMAAC8BAEAJcwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXcAAC4A" +
           "RHcAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBeQAALwEAQAl5AAAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBfQAALgBEfQAAAAEAdAP/////AQH/////" +
           "AAAAAIRggAoBAAAAAQAFAAAAU0MwMDIBAX8AAC8BASIAfwAAAAH/////AQAAABVgiQoCAAAAAQADAAAA" +
           "cHdtAQGAAAAvAQBACYAAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGEAAAu" +
           "AESEAAAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAUAAABUVDAwMgEBhgAALwEBHgCGAAAAAf//" +
           "//8CAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAYcAAC8BAEAJhwAAAAAL/////wMD/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAYsAAC4ARIsAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABwAA" +
           "AFVuaWRhZGUBAY0AAC4ARI0AAAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ValvulaState FV001
        {
            get
            {
                return m_fV001;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fV001, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fV001 = value;
            }
        }

        /// <remarks />
        public InvMotorState SC002
        {
            get
            {
                return m_sC002;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sC002, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sC002 = value;
            }
        }

        /// <remarks />
        public IndicadorTempState TT002
        {
            get
            {
                return m_tT002;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tT002, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tT002 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_fV001 != null)
            {
                children.Add(m_fV001);
            }

            if (m_sC002 != null)
            {
                children.Add(m_sC002);
            }

            if (m_tT002 != null)
            {
                children.Add(m_tT002);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.FV001:
                {
                    if (createOrReplace)
                    {
                        if (FV001 == null)
                        {
                            if (replacement == null)
                            {
                                FV001 = new ValvulaState(this);
                            }
                            else
                            {
                                FV001 = (ValvulaState)replacement;
                            }
                        }
                    }

                    instance = FV001;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.SC002:
                {
                    if (createOrReplace)
                    {
                        if (SC002 == null)
                        {
                            if (replacement == null)
                            {
                                SC002 = new InvMotorState(this);
                            }
                            else
                            {
                                SC002 = (InvMotorState)replacement;
                            }
                        }
                    }

                    instance = SC002;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.TT002:
                {
                    if (createOrReplace)
                    {
                        if (TT002 == null)
                        {
                            if (replacement == null)
                            {
                                TT002 = new IndicadorTempState(this);
                            }
                            else
                            {
                                TT002 = (IndicadorTempState)replacement;
                            }
                        }
                    }

                    instance = TT002;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ValvulaState m_fV001;
        private InvMotorState m_sC002;
        private IndicadorTempState m_tT002;
        #endregion
    }
    #endif
    #endregion

    #region EvaporadorPlantaState Class
    #if (!OPCUA_EXCLUDE_EvaporadorPlantaState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EvaporadorPlantaState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public EvaporadorPlantaState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(EvaporadorPlanta.ObjectTypes.EvaporadorPlantaType, EvaporadorPlanta.Namespaces.EvaporadorPlanta, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRXZhcG9yYWRvclBsYW50Yf////+EYIACAQAA" +
           "AAEAHAAAAEV2YXBvcmFkb3JQbGFudGFUeXBlSW5zdGFuY2UBAY4AAQGOAI4AAAABBwAAAAAwAAEBjwAA" +
           "MAABAZgAADAAAQGuAAAwAAEBvwAAMAABAccAADAAAQHPAAAwAAEB3QAHAAAAhGDACgEAAAAHAAAAVGFu" +
           "cXVlMQEACQAAAFRhbnF1ZTAwMQEBjwAALwEBIwCPAAAAAQIAAAAAMAEBAY4AADAAAQGQAAEAAACEYIAK" +
           "AQAAAAEABQAAAFRUMDAzAQGQAAAvAQEeAJAAAAABAQAAAAAwAQEBjwACAAAAFWCJCgIAAAABAAYAAABP" +
           "dXRwdXQBAZEAAC8BAEAJkQAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZUA" +
           "AC4ARJUAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAFVuaWRhZGUBAZcAAC4ARJcAAAAA" +
           "DP////8DA/////8AAAAAhGDACgEAAAAHAAAAVGFucXVlMgEACQAAAFRhbnF1ZTAwMgEBmAAALwEBLACY" +
           "AAAAAQIAAAAAMAEBAY4AADAAAQGZAAIAAACEYIAKAQAAAAEABQAAAFRUMDAxAQGZAAAvAQEeAJkAAAAB" +
           "AQAAAAAwAQEBmAACAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAZoAAC8BAEAJmgAAAAAL/////wMD////" +
           "/wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZ4AAC4ARJ4AAAABAHQD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEABwAAAFVuaWRhZGUBAaAAAC4ARKAAAAAADP////8DA/////8AAAAAhGCACgEAAAABAAUAAABU" +
           "VjAwMQEBoQAALwEBIQChAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBogAALwEAQAmiAAAA" +
           "AAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpgAALgBEpgAAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGoAAAvAQBACagAAAAAC/////8DA/////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQGsAAAuAESsAAAAAQB0A/////8BAf////8AAAAAhGDACgEAAAAHAAAA" +
           "VGFucXVlMwEACQAAAFRhbnF1ZTAwMwEBrgAALwEBQgCuAAAAAQIAAAAAMAEBAY4AADAAAQG3AAIAAACE" +
           "YIAKAQAAAAEABQAAAFBUMDAxAQGvAAAvAQEfAK8AAAAB/////wIAAAAVYIkKAgAAAAEABgAAAE91dHB1" +
           "dAEBsAAALwEAQAmwAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBtAAALgBE" +
           "tAAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAHAAAAVW5pZGFkZQEBtgAALgBEtgAAAAAM////" +
           "/wMD/////wAAAACEYIAKAQAAAAEABQAAAExUMDAxAQG3AAAvAQEdALcAAAABAQAAAAAwAQEBrgACAAAA" +
           "FWCJCgIAAAABAAYAAABPdXRwdXQBAbgAAC8BAEAJuAAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAbwAAC4ARLwAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAFVuaWRh" +
           "ZGUBAb4AAC4ARL4AAAAADP////8DA/////8AAAAAhGDACgEAAAAIAAAAVDFwYXJhVDIBAAwAAABUMXBh" +
           "cmFUMlgwMDEBAb8AAC8BAVMAvwAAAAECAAAAADABAQGOAAAwAAEBwAABAAAAhGCACgEAAAABAAUAAABT" +
           "QzAwMQEBwAAALwEBIgDAAAAAAQEAAAAAMAEBAb8AAQAAABVgiQoCAAAAAQADAAAAcHdtAQHBAAAvAQBA" +
           "CcEAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHFAAAuAETFAAAAAQB0A///" +
           "//8BAf////8AAAAAhGDACgEAAAAIAAAAVDFwYXJhVDMBAAwAAABUMXBhcmFUM1gwMDEBAccAAC8BAVsA" +
           "xwAAAAECAAAAADABAQGOAAAwAAEByAABAAAAhGCACgEAAAABAAUAAABTQzAwMwEByAAALwEBIgDIAAAA" +
           "AQEAAAAAMAEBAccAAQAAABVgiQoCAAAAAQADAAAAcHdtAQHJAAAvAQBACckAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHNAAAuAETNAAAAAQB0A/////8BAf////8AAAAAhGDACgEA" +
           "AAAIAAAAVDJwYXJhQ3gBAAwAAABUMnBhcmFDeFgwMDEBAc8AAC8BAWMAzwAAAAECAAAAADABAQGOAAAw" +
           "AAEB0AABAAAAhGCACgEAAAABAAUAAABGVjAwMgEB0AAALwEBIADQAAAAAQEAAAAAMAEBAc8AAgAAABVg" +
           "iQoCAAAAAQAFAAAASW5wdXQBAdEAAC8BAEAJ0QAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAdUAAC4ARNUAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB" +
           "1wAALwEAQAnXAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB2wAALgBE2wAA" +
           "AAEAdAP/////AQH/////AAAAAIRgwAoBAAAACAAAAFQzcGFyYUN4AQAMAAAAVDNwYXJhQ3hYMDAxAQHd" +
           "AAAvAQFxAN0AAAABAgAAAAAwAQEBjgAAMAABAd4AAwAAAIRggAoBAAAAAQAFAAAARlYwMDEBAd4AAC8B" +
           "ASAA3gAAAAEBAAAAADABAQHdAAIAAAAVYIkKAgAAAAEABQAAAElucHV0AQHfAAAvAQBACd8AAAAAC///" +
           "//8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHjAAAuAETjAAAAAQB0A/////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAeUAAC8BAEAJ5QAAAAAL/////wMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAekAAC4AROkAAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEABQAAAFND" +
           "MDAyAQHrAAAvAQEiAOsAAAAB/////wEAAAAVYIkKAgAAAAEAAwAAAHB3bQEB7AAALwEAQAnsAAAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB8AAALgBE8AAAAAEAdAP/////AQH/////" +
           "AAAAAIRggAoBAAAAAQAFAAAAVFQwMDIBAfIAAC8BAR4A8gAAAAH/////AgAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQHzAAAvAQBACfMAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH3" +
           "AAAuAET3AAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAcAAABVbmlkYWRlAQH5AAAuAET5AAAA" +
           "AAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public Tanque1State Tanque1
        {
            get
            {
                return m_tanque1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tanque1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tanque1 = value;
            }
        }

        /// <remarks />
        public Tanque2State Tanque2
        {
            get
            {
                return m_tanque2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tanque2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tanque2 = value;
            }
        }

        /// <remarks />
        public Tanque3State Tanque3
        {
            get
            {
                return m_tanque3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tanque3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tanque3 = value;
            }
        }

        /// <remarks />
        public T1paraT2State T1paraT2
        {
            get
            {
                return m_t1paraT2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_t1paraT2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_t1paraT2 = value;
            }
        }

        /// <remarks />
        public T1paraT3State T1paraT3
        {
            get
            {
                return m_t1paraT3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_t1paraT3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_t1paraT3 = value;
            }
        }

        /// <remarks />
        public T2paraCxState T2paraCx
        {
            get
            {
                return m_t2paraCx;
            }

            set
            {
                if (!Object.ReferenceEquals(m_t2paraCx, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_t2paraCx = value;
            }
        }

        /// <remarks />
        public T3paraCxState T3paraCx
        {
            get
            {
                return m_t3paraCx;
            }

            set
            {
                if (!Object.ReferenceEquals(m_t3paraCx, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_t3paraCx = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tanque1 != null)
            {
                children.Add(m_tanque1);
            }

            if (m_tanque2 != null)
            {
                children.Add(m_tanque2);
            }

            if (m_tanque3 != null)
            {
                children.Add(m_tanque3);
            }

            if (m_t1paraT2 != null)
            {
                children.Add(m_t1paraT2);
            }

            if (m_t1paraT3 != null)
            {
                children.Add(m_t1paraT3);
            }

            if (m_t2paraCx != null)
            {
                children.Add(m_t2paraCx);
            }

            if (m_t3paraCx != null)
            {
                children.Add(m_t3paraCx);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case EvaporadorPlanta.BrowseNames.Tanque1:
                {
                    if (createOrReplace)
                    {
                        if (Tanque1 == null)
                        {
                            if (replacement == null)
                            {
                                Tanque1 = new Tanque1State(this);
                            }
                            else
                            {
                                Tanque1 = (Tanque1State)replacement;
                            }
                        }
                    }

                    instance = Tanque1;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.Tanque2:
                {
                    if (createOrReplace)
                    {
                        if (Tanque2 == null)
                        {
                            if (replacement == null)
                            {
                                Tanque2 = new Tanque2State(this);
                            }
                            else
                            {
                                Tanque2 = (Tanque2State)replacement;
                            }
                        }
                    }

                    instance = Tanque2;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.Tanque3:
                {
                    if (createOrReplace)
                    {
                        if (Tanque3 == null)
                        {
                            if (replacement == null)
                            {
                                Tanque3 = new Tanque3State(this);
                            }
                            else
                            {
                                Tanque3 = (Tanque3State)replacement;
                            }
                        }
                    }

                    instance = Tanque3;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.T1paraT2:
                {
                    if (createOrReplace)
                    {
                        if (T1paraT2 == null)
                        {
                            if (replacement == null)
                            {
                                T1paraT2 = new T1paraT2State(this);
                            }
                            else
                            {
                                T1paraT2 = (T1paraT2State)replacement;
                            }
                        }
                    }

                    instance = T1paraT2;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.T1paraT3:
                {
                    if (createOrReplace)
                    {
                        if (T1paraT3 == null)
                        {
                            if (replacement == null)
                            {
                                T1paraT3 = new T1paraT3State(this);
                            }
                            else
                            {
                                T1paraT3 = (T1paraT3State)replacement;
                            }
                        }
                    }

                    instance = T1paraT3;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.T2paraCx:
                {
                    if (createOrReplace)
                    {
                        if (T2paraCx == null)
                        {
                            if (replacement == null)
                            {
                                T2paraCx = new T2paraCxState(this);
                            }
                            else
                            {
                                T2paraCx = (T2paraCxState)replacement;
                            }
                        }
                    }

                    instance = T2paraCx;
                    break;
                }

                case EvaporadorPlanta.BrowseNames.T3paraCx:
                {
                    if (createOrReplace)
                    {
                        if (T3paraCx == null)
                        {
                            if (replacement == null)
                            {
                                T3paraCx = new T3paraCxState(this);
                            }
                            else
                            {
                                T3paraCx = (T3paraCxState)replacement;
                            }
                        }
                    }

                    instance = T3paraCx;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private Tanque1State m_tanque1;
        private Tanque2State m_tanque2;
        private Tanque3State m_tanque3;
        private T1paraT2State m_t1paraT2;
        private T1paraT3State m_t1paraT3;
        private T2paraCxState m_t2paraCx;
        private T3paraCxState m_t3paraCx;
        #endregion
    }
    #endif
    #endregion
}