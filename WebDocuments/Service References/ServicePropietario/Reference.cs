﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDocuments.ServicePropietario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BEPropietario", Namespace="http://schemas.datacontract.org/2004/07/eDocuments.Entities")]
    [System.SerializableAttribute()]
    public partial class BEPropietario : WebDocuments.ServicePropietario.Auditoria {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cod_propietarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gls_propietarioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_propietario {
            get {
                return this.cod_propietarioField;
            }
            set {
                if ((this.cod_propietarioField.Equals(value) != true)) {
                    this.cod_propietarioField = value;
                    this.RaisePropertyChanged("cod_propietario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gls_propietario {
            get {
                return this.gls_propietarioField;
            }
            set {
                if ((object.ReferenceEquals(this.gls_propietarioField, value) != true)) {
                    this.gls_propietarioField = value;
                    this.RaisePropertyChanged("gls_propietario");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auditoria", Namespace="http://schemas.datacontract.org/2004/07/eDocuments.Entities")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebDocuments.ServicePropietario.BEPropietario))]
    public partial class Auditoria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime aud_fec_ingresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime aud_fec_modificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aud_usr_ingresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aud_usr_modificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cod_estado_registroField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime aud_fec_ingreso {
            get {
                return this.aud_fec_ingresoField;
            }
            set {
                if ((this.aud_fec_ingresoField.Equals(value) != true)) {
                    this.aud_fec_ingresoField = value;
                    this.RaisePropertyChanged("aud_fec_ingreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime aud_fec_modificacion {
            get {
                return this.aud_fec_modificacionField;
            }
            set {
                if ((this.aud_fec_modificacionField.Equals(value) != true)) {
                    this.aud_fec_modificacionField = value;
                    this.RaisePropertyChanged("aud_fec_modificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string aud_usr_ingreso {
            get {
                return this.aud_usr_ingresoField;
            }
            set {
                if ((object.ReferenceEquals(this.aud_usr_ingresoField, value) != true)) {
                    this.aud_usr_ingresoField = value;
                    this.RaisePropertyChanged("aud_usr_ingreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string aud_usr_modificacion {
            get {
                return this.aud_usr_modificacionField;
            }
            set {
                if ((object.ReferenceEquals(this.aud_usr_modificacionField, value) != true)) {
                    this.aud_usr_modificacionField = value;
                    this.RaisePropertyChanged("aud_usr_modificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_estado_registro {
            get {
                return this.cod_estado_registroField;
            }
            set {
                if ((this.cod_estado_registroField.Equals(value) != true)) {
                    this.cod_estado_registroField = value;
                    this.RaisePropertyChanged("cod_estado_registro");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicePropietario.IPropietarioService")]
    public interface IPropietarioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/ListarPropietario", ReplyAction="http://tempuri.org/IPropietarioService/ListarPropietarioResponse")]
        WebDocuments.ServicePropietario.BEPropietario[] ListarPropietario(string propietario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/ListarPropietario", ReplyAction="http://tempuri.org/IPropietarioService/ListarPropietarioResponse")]
        System.Threading.Tasks.Task<WebDocuments.ServicePropietario.BEPropietario[]> ListarPropietarioAsync(string propietario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/Registrar", ReplyAction="http://tempuri.org/IPropietarioService/RegistrarResponse")]
        int Registrar(WebDocuments.ServicePropietario.BEPropietario oParametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/Registrar", ReplyAction="http://tempuri.org/IPropietarioService/RegistrarResponse")]
        System.Threading.Tasks.Task<int> RegistrarAsync(WebDocuments.ServicePropietario.BEPropietario oParametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/Actualizar", ReplyAction="http://tempuri.org/IPropietarioService/ActualizarResponse")]
        int Actualizar(WebDocuments.ServicePropietario.BEPropietario oParametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/Actualizar", ReplyAction="http://tempuri.org/IPropietarioService/ActualizarResponse")]
        System.Threading.Tasks.Task<int> ActualizarAsync(WebDocuments.ServicePropietario.BEPropietario oParametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/Eliminar", ReplyAction="http://tempuri.org/IPropietarioService/EliminarResponse")]
        int Eliminar(WebDocuments.ServicePropietario.BEPropietario oParametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropietarioService/Eliminar", ReplyAction="http://tempuri.org/IPropietarioService/EliminarResponse")]
        System.Threading.Tasks.Task<int> EliminarAsync(WebDocuments.ServicePropietario.BEPropietario oParametro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPropietarioServiceChannel : WebDocuments.ServicePropietario.IPropietarioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PropietarioServiceClient : System.ServiceModel.ClientBase<WebDocuments.ServicePropietario.IPropietarioService>, WebDocuments.ServicePropietario.IPropietarioService {
        
        public PropietarioServiceClient() {
        }
        
        public PropietarioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PropietarioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PropietarioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PropietarioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebDocuments.ServicePropietario.BEPropietario[] ListarPropietario(string propietario) {
            return base.Channel.ListarPropietario(propietario);
        }
        
        public System.Threading.Tasks.Task<WebDocuments.ServicePropietario.BEPropietario[]> ListarPropietarioAsync(string propietario) {
            return base.Channel.ListarPropietarioAsync(propietario);
        }
        
        public int Registrar(WebDocuments.ServicePropietario.BEPropietario oParametro) {
            return base.Channel.Registrar(oParametro);
        }
        
        public System.Threading.Tasks.Task<int> RegistrarAsync(WebDocuments.ServicePropietario.BEPropietario oParametro) {
            return base.Channel.RegistrarAsync(oParametro);
        }
        
        public int Actualizar(WebDocuments.ServicePropietario.BEPropietario oParametro) {
            return base.Channel.Actualizar(oParametro);
        }
        
        public System.Threading.Tasks.Task<int> ActualizarAsync(WebDocuments.ServicePropietario.BEPropietario oParametro) {
            return base.Channel.ActualizarAsync(oParametro);
        }
        
        public int Eliminar(WebDocuments.ServicePropietario.BEPropietario oParametro) {
            return base.Channel.Eliminar(oParametro);
        }
        
        public System.Threading.Tasks.Task<int> EliminarAsync(WebDocuments.ServicePropietario.BEPropietario oParametro) {
            return base.Channel.EliminarAsync(oParametro);
        }
    }
}