﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace R2PB.AnalisisCodigo.AC.ClienteAnalisis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Paquete", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Paquetes")]
    [System.SerializableAttribute()]
    public partial class Paquete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdSolucionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombrePaqueteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Proyecto[] ProyectosField;
        
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
        public string NombrePaquete {
            get {
                return this.NombrePaqueteField;
            }
            set {
                if ((object.ReferenceEquals(this.NombrePaqueteField, value) != true)) {
                    this.NombrePaqueteField = value;
                    this.RaisePropertyChanged("NombrePaquete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Proyecto[] Proyectos {
            get {
                return this.ProyectosField;
            }
            set {
                if ((object.ReferenceEquals(this.ProyectosField, value) != true)) {
                    this.ProyectosField = value;
                    this.RaisePropertyChanged("Proyectos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Proyecto", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Proyectos")]
    [System.SerializableAttribute()]
    public partial class Proyecto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Clase[] ClasesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdProyectoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LenguajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreProyectoField;
        
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
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Clase[] Clases {
            get {
                return this.ClasesField;
            }
            set {
                if ((object.ReferenceEquals(this.ClasesField, value) != true)) {
                    this.ClasesField = value;
                    this.RaisePropertyChanged("Clases");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdProyecto {
            get {
                return this.IdProyectoField;
            }
            set {
                if ((object.ReferenceEquals(this.IdProyectoField, value) != true)) {
                    this.IdProyectoField = value;
                    this.RaisePropertyChanged("IdProyecto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lenguaje {
            get {
                return this.LenguajeField;
            }
            set {
                if ((object.ReferenceEquals(this.LenguajeField, value) != true)) {
                    this.LenguajeField = value;
                    this.RaisePropertyChanged("Lenguaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProyecto {
            get {
                return this.NombreProyectoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreProyectoField, value) != true)) {
                    this.NombreProyectoField = value;
                    this.RaisePropertyChanged("NombreProyecto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Clase", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Clases")]
    [System.SerializableAttribute()]
    public partial class Clase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Herencia[] HerenciasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineaComienzoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineaFinalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Metodo[] MetodosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameSpaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Propiedad[] PropiedadesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.BC.Clases.Tipo TipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Using[] UsingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VisibilidadField;
        
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
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Herencia[] Herencias {
            get {
                return this.HerenciasField;
            }
            set {
                if ((object.ReferenceEquals(this.HerenciasField, value) != true)) {
                    this.HerenciasField = value;
                    this.RaisePropertyChanged("Herencias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LineaComienzo {
            get {
                return this.LineaComienzoField;
            }
            set {
                if ((this.LineaComienzoField.Equals(value) != true)) {
                    this.LineaComienzoField = value;
                    this.RaisePropertyChanged("LineaComienzo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LineaFinal {
            get {
                return this.LineaFinalField;
            }
            set {
                if ((this.LineaFinalField.Equals(value) != true)) {
                    this.LineaFinalField = value;
                    this.RaisePropertyChanged("LineaFinal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Metodo[] Metodos {
            get {
                return this.MetodosField;
            }
            set {
                if ((object.ReferenceEquals(this.MetodosField, value) != true)) {
                    this.MetodosField = value;
                    this.RaisePropertyChanged("Metodos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameSpace {
            get {
                return this.NameSpaceField;
            }
            set {
                if ((object.ReferenceEquals(this.NameSpaceField, value) != true)) {
                    this.NameSpaceField = value;
                    this.RaisePropertyChanged("NameSpace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Propiedad[] Propiedades {
            get {
                return this.PropiedadesField;
            }
            set {
                if ((object.ReferenceEquals(this.PropiedadesField, value) != true)) {
                    this.PropiedadesField = value;
                    this.RaisePropertyChanged("Propiedades");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.BC.Clases.Tipo Tipo {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Using[] Usings {
            get {
                return this.UsingsField;
            }
            set {
                if ((object.ReferenceEquals(this.UsingsField, value) != true)) {
                    this.UsingsField = value;
                    this.RaisePropertyChanged("Usings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Visibilidad {
            get {
                return this.VisibilidadField;
            }
            set {
                if ((object.ReferenceEquals(this.VisibilidadField, value) != true)) {
                    this.VisibilidadField = value;
                    this.RaisePropertyChanged("Visibilidad");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Herencia", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Herencias")]
    [System.SerializableAttribute()]
    public partial class Herencia : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeclaracionHerenciaField;
        
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
        public string DeclaracionHerencia {
            get {
                return this.DeclaracionHerenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.DeclaracionHerenciaField, value) != true)) {
                    this.DeclaracionHerenciaField = value;
                    this.RaisePropertyChanged("DeclaracionHerencia");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Metodo", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Metodos")]
    [System.SerializableAttribute()]
    public partial class Metodo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Control[] ControlesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineaComienzoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineaFinalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreMetodoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Parametro[] ParametrosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RetornoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VisibilidadField;
        
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
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Control[] Controles {
            get {
                return this.ControlesField;
            }
            set {
                if ((object.ReferenceEquals(this.ControlesField, value) != true)) {
                    this.ControlesField = value;
                    this.RaisePropertyChanged("Controles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LineaComienzo {
            get {
                return this.LineaComienzoField;
            }
            set {
                if ((this.LineaComienzoField.Equals(value) != true)) {
                    this.LineaComienzoField = value;
                    this.RaisePropertyChanged("LineaComienzo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LineaFinal {
            get {
                return this.LineaFinalField;
            }
            set {
                if ((this.LineaFinalField.Equals(value) != true)) {
                    this.LineaFinalField = value;
                    this.RaisePropertyChanged("LineaFinal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreMetodo {
            get {
                return this.NombreMetodoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreMetodoField, value) != true)) {
                    this.NombreMetodoField = value;
                    this.RaisePropertyChanged("NombreMetodo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Parametro[] Parametros {
            get {
                return this.ParametrosField;
            }
            set {
                if ((object.ReferenceEquals(this.ParametrosField, value) != true)) {
                    this.ParametrosField = value;
                    this.RaisePropertyChanged("Parametros");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Retorno {
            get {
                return this.RetornoField;
            }
            set {
                if ((object.ReferenceEquals(this.RetornoField, value) != true)) {
                    this.RetornoField = value;
                    this.RaisePropertyChanged("Retorno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Visibilidad {
            get {
                return this.VisibilidadField;
            }
            set {
                if ((object.ReferenceEquals(this.VisibilidadField, value) != true)) {
                    this.VisibilidadField = value;
                    this.RaisePropertyChanged("Visibilidad");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Propiedad", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Propiedades")]
    [System.SerializableAttribute()]
    public partial class Propiedad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EsEstaticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VisibilidadField;
        
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
        public bool EsEstatica {
            get {
                return this.EsEstaticaField;
            }
            set {
                if ((this.EsEstaticaField.Equals(value) != true)) {
                    this.EsEstaticaField = value;
                    this.RaisePropertyChanged("EsEstatica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoField, value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Visibilidad {
            get {
                return this.VisibilidadField;
            }
            set {
                if ((object.ReferenceEquals(this.VisibilidadField, value) != true)) {
                    this.VisibilidadField = value;
                    this.RaisePropertyChanged("Visibilidad");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Using", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Usings")]
    [System.SerializableAttribute()]
    public partial class Using : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsingDeclaradoField;
        
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
        public string UsingDeclarado {
            get {
                return this.UsingDeclaradoField;
            }
            set {
                if ((object.ReferenceEquals(this.UsingDeclaradoField, value) != true)) {
                    this.UsingDeclaradoField = value;
                    this.RaisePropertyChanged("UsingDeclarado");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Control", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Metodos")]
    [System.SerializableAttribute()]
    public partial class Control : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineaComienzoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineaFinalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreSintaxisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.AC.ClienteAnalisis.Control OtroControlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private R2PB.AnalisisCodigo.BC.Controles.Tipo TipoControlField;
        
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
        public int LineaComienzo {
            get {
                return this.LineaComienzoField;
            }
            set {
                if ((this.LineaComienzoField.Equals(value) != true)) {
                    this.LineaComienzoField = value;
                    this.RaisePropertyChanged("LineaComienzo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LineaFinal {
            get {
                return this.LineaFinalField;
            }
            set {
                if ((this.LineaFinalField.Equals(value) != true)) {
                    this.LineaFinalField = value;
                    this.RaisePropertyChanged("LineaFinal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreSintaxis {
            get {
                return this.NombreSintaxisField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreSintaxisField, value) != true)) {
                    this.NombreSintaxisField = value;
                    this.RaisePropertyChanged("NombreSintaxis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.AC.ClienteAnalisis.Control OtroControl {
            get {
                return this.OtroControlField;
            }
            set {
                if ((object.ReferenceEquals(this.OtroControlField, value) != true)) {
                    this.OtroControlField = value;
                    this.RaisePropertyChanged("OtroControl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public R2PB.AnalisisCodigo.BC.Controles.Tipo TipoControl {
            get {
                return this.TipoControlField;
            }
            set {
                if ((this.TipoControlField.Equals(value) != true)) {
                    this.TipoControlField = value;
                    this.RaisePropertyChanged("TipoControl");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Parametro", Namespace="http://schemas.datacontract.org/2004/07/R2PB.AnalisisCodigo.SI.Datos.Metodos")]
    [System.SerializableAttribute()]
    public partial class Parametro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EsStaticoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] TieneMasModificadoresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoField;
        
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
        public bool EsStatico {
            get {
                return this.EsStaticoField;
            }
            set {
                if ((this.EsStaticoField.Equals(value) != true)) {
                    this.EsStaticoField = value;
                    this.RaisePropertyChanged("EsStatico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] TieneMasModificadores {
            get {
                return this.TieneMasModificadoresField;
            }
            set {
                if ((object.ReferenceEquals(this.TieneMasModificadoresField, value) != true)) {
                    this.TieneMasModificadoresField = value;
                    this.RaisePropertyChanged("TieneMasModificadores");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoField, value) != true)) {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteAnalisis.ISolucionesCodigoFuente")]
    public interface ISolucionesCodigoFuente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolucionesCodigoFuente/GuardeElPaquete", ReplyAction="http://tempuri.org/ISolucionesCodigoFuente/GuardeElPaqueteResponse")]
        int GuardeElPaquete(R2PB.AnalisisCodigo.AC.ClienteAnalisis.Paquete elPaquete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolucionesCodigoFuente/GuardeElPaquete", ReplyAction="http://tempuri.org/ISolucionesCodigoFuente/GuardeElPaqueteResponse")]
        System.Threading.Tasks.Task<int> GuardeElPaqueteAsync(R2PB.AnalisisCodigo.AC.ClienteAnalisis.Paquete elPaquete);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISolucionesCodigoFuenteChannel : R2PB.AnalisisCodigo.AC.ClienteAnalisis.ISolucionesCodigoFuente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SolucionesCodigoFuenteClient : System.ServiceModel.ClientBase<R2PB.AnalisisCodigo.AC.ClienteAnalisis.ISolucionesCodigoFuente>, R2PB.AnalisisCodigo.AC.ClienteAnalisis.ISolucionesCodigoFuente {
        
        public SolucionesCodigoFuenteClient() {
        }
        
        public SolucionesCodigoFuenteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SolucionesCodigoFuenteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolucionesCodigoFuenteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolucionesCodigoFuenteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GuardeElPaquete(R2PB.AnalisisCodigo.AC.ClienteAnalisis.Paquete elPaquete) {
            return base.Channel.GuardeElPaquete(elPaquete);
        }
        
        public System.Threading.Tasks.Task<int> GuardeElPaqueteAsync(R2PB.AnalisisCodigo.AC.ClienteAnalisis.Paquete elPaquete) {
            return base.Channel.GuardeElPaqueteAsync(elPaquete);
        }
    }
}
