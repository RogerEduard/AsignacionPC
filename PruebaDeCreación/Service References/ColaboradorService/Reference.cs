﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaDeCreación.ColaboradorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Colaborador", Namespace="http://schemas.datacontract.org/2004/07/WCF_AsignacionPCs.Dominio")]
    [System.SerializableAttribute()]
    public partial class Colaborador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cargoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechanacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ingresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
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
        public string cargo {
            get {
                return this.cargoField;
            }
            set {
                if ((object.ReferenceEquals(this.cargoField, value) != true)) {
                    this.cargoField = value;
                    this.RaisePropertyChanged("cargo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codigo {
            get {
                return this.codigoField;
            }
            set {
                if ((this.codigoField.Equals(value) != true)) {
                    this.codigoField = value;
                    this.RaisePropertyChanged("codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechanacimiento {
            get {
                return this.fechanacimientoField;
            }
            set {
                if ((this.fechanacimientoField.Equals(value) != true)) {
                    this.fechanacimientoField = value;
                    this.RaisePropertyChanged("fechanacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ingreso {
            get {
                return this.ingresoField;
            }
            set {
                if ((this.ingresoField.Equals(value) != true)) {
                    this.ingresoField = value;
                    this.RaisePropertyChanged("ingreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoExcepcion", Namespace="http://schemas.datacontract.org/2004/07/WCF_AsignacionPCs.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoExcepcion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
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
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ColaboradorService.IColaboradores")]
    public interface IColaboradores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/CrearColaborador", ReplyAction="http://tempuri.org/IColaboradores/CrearColaboradorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PruebaDeCreación.ColaboradorService.RepetidoExcepcion), Action="http://tempuri.org/IColaboradores/CrearColaboradorRepetidoExcepcionFault", Name="RepetidoExcepcion", Namespace="http://schemas.datacontract.org/2004/07/WCF_AsignacionPCs.Errores")]
        PruebaDeCreación.ColaboradorService.Colaborador CrearColaborador(PruebaDeCreación.ColaboradorService.Colaborador colaboradorCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/CrearColaborador", ReplyAction="http://tempuri.org/IColaboradores/CrearColaboradorResponse")]
        System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador> CrearColaboradorAsync(PruebaDeCreación.ColaboradorService.Colaborador colaboradorCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/ObtenerColaborador", ReplyAction="http://tempuri.org/IColaboradores/ObtenerColaboradorResponse")]
        PruebaDeCreación.ColaboradorService.Colaborador ObtenerColaborador(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/ObtenerColaborador", ReplyAction="http://tempuri.org/IColaboradores/ObtenerColaboradorResponse")]
        System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador> ObtenerColaboradorAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/ModificarColaborador", ReplyAction="http://tempuri.org/IColaboradores/ModificarColaboradorResponse")]
        PruebaDeCreación.ColaboradorService.Colaborador ModificarColaborador(PruebaDeCreación.ColaboradorService.Colaborador colaboradorModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/ModificarColaborador", ReplyAction="http://tempuri.org/IColaboradores/ModificarColaboradorResponse")]
        System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador> ModificarColaboradorAsync(PruebaDeCreación.ColaboradorService.Colaborador colaboradorModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/EliminarColaborador", ReplyAction="http://tempuri.org/IColaboradores/EliminarColaboradorResponse")]
        void EliminarColaborador(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/EliminarColaborador", ReplyAction="http://tempuri.org/IColaboradores/EliminarColaboradorResponse")]
        System.Threading.Tasks.Task EliminarColaboradorAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/ListarColaborador", ReplyAction="http://tempuri.org/IColaboradores/ListarColaboradorResponse")]
        PruebaDeCreación.ColaboradorService.Colaborador[] ListarColaborador();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColaboradores/ListarColaborador", ReplyAction="http://tempuri.org/IColaboradores/ListarColaboradorResponse")]
        System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador[]> ListarColaboradorAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IColaboradoresChannel : PruebaDeCreación.ColaboradorService.IColaboradores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ColaboradoresClient : System.ServiceModel.ClientBase<PruebaDeCreación.ColaboradorService.IColaboradores>, PruebaDeCreación.ColaboradorService.IColaboradores {
        
        public ColaboradoresClient() {
        }
        
        public ColaboradoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ColaboradoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ColaboradoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ColaboradoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PruebaDeCreación.ColaboradorService.Colaborador CrearColaborador(PruebaDeCreación.ColaboradorService.Colaborador colaboradorCrear) {
            return base.Channel.CrearColaborador(colaboradorCrear);
        }
        
        public System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador> CrearColaboradorAsync(PruebaDeCreación.ColaboradorService.Colaborador colaboradorCrear) {
            return base.Channel.CrearColaboradorAsync(colaboradorCrear);
        }
        
        public PruebaDeCreación.ColaboradorService.Colaborador ObtenerColaborador(int codigo) {
            return base.Channel.ObtenerColaborador(codigo);
        }
        
        public System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador> ObtenerColaboradorAsync(int codigo) {
            return base.Channel.ObtenerColaboradorAsync(codigo);
        }
        
        public PruebaDeCreación.ColaboradorService.Colaborador ModificarColaborador(PruebaDeCreación.ColaboradorService.Colaborador colaboradorModificar) {
            return base.Channel.ModificarColaborador(colaboradorModificar);
        }
        
        public System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador> ModificarColaboradorAsync(PruebaDeCreación.ColaboradorService.Colaborador colaboradorModificar) {
            return base.Channel.ModificarColaboradorAsync(colaboradorModificar);
        }
        
        public void EliminarColaborador(int codigo) {
            base.Channel.EliminarColaborador(codigo);
        }
        
        public System.Threading.Tasks.Task EliminarColaboradorAsync(int codigo) {
            return base.Channel.EliminarColaboradorAsync(codigo);
        }
        
        public PruebaDeCreación.ColaboradorService.Colaborador[] ListarColaborador() {
            return base.Channel.ListarColaborador();
        }
        
        public System.Threading.Tasks.Task<PruebaDeCreación.ColaboradorService.Colaborador[]> ListarColaboradorAsync() {
            return base.Channel.ListarColaboradorAsync();
        }
    }
}
