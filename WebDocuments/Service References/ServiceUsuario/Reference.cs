﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDocuments.ServiceUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auditoria", Namespace="http://schemas.datacontract.org/2004/07/eDocuments.Entities")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebDocuments.ServiceUsuario.BEUsuario))]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BEUsuario", Namespace="http://schemas.datacontract.org/2004/07/eDocuments.Entities")]
    [System.SerializableAttribute()]
    public partial class BEUsuario : WebDocuments.ServiceUsuario.Auditoria {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ape_maternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ape_paternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cod_areaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cod_rolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cod_usuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string correoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gls_areaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gls_rolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombresField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ape_materno {
            get {
                return this.ape_maternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ape_maternoField, value) != true)) {
                    this.ape_maternoField = value;
                    this.RaisePropertyChanged("ape_materno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ape_paterno {
            get {
                return this.ape_paternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ape_paternoField, value) != true)) {
                    this.ape_paternoField = value;
                    this.RaisePropertyChanged("ape_paterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_area {
            get {
                return this.cod_areaField;
            }
            set {
                if ((this.cod_areaField.Equals(value) != true)) {
                    this.cod_areaField = value;
                    this.RaisePropertyChanged("cod_area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cod_rol {
            get {
                return this.cod_rolField;
            }
            set {
                if ((this.cod_rolField.Equals(value) != true)) {
                    this.cod_rolField = value;
                    this.RaisePropertyChanged("cod_rol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cod_usuario {
            get {
                return this.cod_usuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.cod_usuarioField, value) != true)) {
                    this.cod_usuarioField = value;
                    this.RaisePropertyChanged("cod_usuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                if ((object.ReferenceEquals(this.correoField, value) != true)) {
                    this.correoField = value;
                    this.RaisePropertyChanged("correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gls_area {
            get {
                return this.gls_areaField;
            }
            set {
                if ((object.ReferenceEquals(this.gls_areaField, value) != true)) {
                    this.gls_areaField = value;
                    this.RaisePropertyChanged("gls_area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gls_rol {
            get {
                return this.gls_rolField;
            }
            set {
                if ((object.ReferenceEquals(this.gls_rolField, value) != true)) {
                    this.gls_rolField = value;
                    this.RaisePropertyChanged("gls_rol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombres {
            get {
                return this.nombresField;
            }
            set {
                if ((object.ReferenceEquals(this.nombresField, value) != true)) {
                    this.nombresField = value;
                    this.RaisePropertyChanged("nombres");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceUsuario.IUsuarioService")]
    public interface IUsuarioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/SayHello", ReplyAction="http://tempuri.org/IUsuarioService/SayHelloResponse")]
        string SayHello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/SayHello", ReplyAction="http://tempuri.org/IUsuarioService/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuarioLogin", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioLoginResponse")]
        WebDocuments.ServiceUsuario.BEUsuario ObtenerUsuarioLogin(string usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuarioLogin", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioLoginResponse")]
        System.Threading.Tasks.Task<WebDocuments.ServiceUsuario.BEUsuario> ObtenerUsuarioLoginAsync(string usuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioServiceChannel : WebDocuments.ServiceUsuario.IUsuarioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioServiceClient : System.ServiceModel.ClientBase<WebDocuments.ServiceUsuario.IUsuarioService>, WebDocuments.ServiceUsuario.IUsuarioService {
        
        public UsuarioServiceClient() {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello(string name) {
            return base.Channel.SayHello(name);
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync(string name) {
            return base.Channel.SayHelloAsync(name);
        }
        
        public WebDocuments.ServiceUsuario.BEUsuario ObtenerUsuarioLogin(string usuario) {
            return base.Channel.ObtenerUsuarioLogin(usuario);
        }
        
        public System.Threading.Tasks.Task<WebDocuments.ServiceUsuario.BEUsuario> ObtenerUsuarioLoginAsync(string usuario) {
            return base.Channel.ObtenerUsuarioLoginAsync(usuario);
        }
    }
}
