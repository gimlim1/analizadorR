﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace R2PB.AnalisisCodigo.AC.Bitacoras {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bitacora", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Bitacoras")]
    [System.SerializableAttribute()]
    public partial class Bitacora : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdSolucionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MasInformacionExcepcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.BC.Componentes TipoField;
        
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
        public string IdSolucion {
            get {
                return this.IdSolucionField;
            }
            set {
                if ((object.ReferenceEquals(this.IdSolucionField, value) != true)) {
                    this.IdSolucionField = value;
                    this.RaisePropertyChanged("IdSolucion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MasInformacionExcepcion {
            get {
                return this.MasInformacionExcepcionField;
            }
            set {
                if ((object.ReferenceEquals(this.MasInformacionExcepcionField, value) != true)) {
                    this.MasInformacionExcepcionField = value;
                    this.RaisePropertyChanged("MasInformacionExcepcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.BC.Componentes Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((this.TipoField.Equals(value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Bitacoras.IBitacora")]
    public interface IBitacora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBitacora/RegistreError", ReplyAction="http://tempuri.org/IBitacora/RegistreErrorResponse")]
        void RegistreError(R2PB.AnalisisCodigo.AC.Bitacoras.Bitacora laBitacora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBitacora/RegistreError", ReplyAction="http://tempuri.org/IBitacora/RegistreErrorResponse")]
        System.Threading.Tasks.Task RegistreErrorAsync(R2PB.AnalisisCodigo.AC.Bitacoras.Bitacora laBitacora);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBitacoraChannel : R2PB.AnalisisCodigo.AC.Bitacoras.IBitacora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BitacoraClient : System.ServiceModel.ClientBase<R2PB.AnalisisCodigo.AC.Bitacoras.IBitacora>, R2PB.AnalisisCodigo.AC.Bitacoras.IBitacora {
        
        public BitacoraClient() {
        }
        
        public BitacoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BitacoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BitacoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BitacoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegistreError(R2PB.AnalisisCodigo.AC.Bitacoras.Bitacora laBitacora) {
            base.Channel.RegistreError(laBitacora);
        }
        
        public System.Threading.Tasks.Task RegistreErrorAsync(R2PB.AnalisisCodigo.AC.Bitacoras.Bitacora laBitacora) {
            return base.Channel.RegistreErrorAsync(laBitacora);
        }
    }
}
