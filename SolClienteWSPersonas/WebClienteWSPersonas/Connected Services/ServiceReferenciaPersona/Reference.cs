﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClienteWSPersonas.ServiceReferenciaPersona {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntPersonas", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class EntPersonas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        private int EdadField;
        
        private System.DateTime FechaAltaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMaternoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime FechaAlta {
            get {
                return this.FechaAltaField;
            }
            set {
                if ((this.FechaAltaField.Equals(value) != true)) {
                    this.FechaAltaField = value;
                    this.RaisePropertyChanged("FechaAlta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenciaPersona.WSPersonasSoap")]
    public interface WSPersonasSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ObtenerResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Obtener", ReplyAction="*")]
        WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponse Obtener(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Obtener", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponse> ObtenerAsync(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ObtenerPorIdResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPorId", ReplyAction="*")]
        WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponse ObtenerPorId(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPorId", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponse> ObtenerPorIdAsync(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento p del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponse Agregar(WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponse> AgregarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento p del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Editar", ReplyAction="*")]
        WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponse Editar(WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Editar", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponse> EditarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento p del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Borrar", ReplyAction="*")]
        WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponse Borrar(WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Borrar", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponse> BorrarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Obtener", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequestBody Body;
        
        public ObtenerRequest() {
        }
        
        public ObtenerRequest(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ObtenerRequestBody {
        
        public ObtenerRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponseBody Body;
        
        public ObtenerResponse() {
        }
        
        public ObtenerResponse(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas[] ObtenerResult;
        
        public ObtenerResponseBody() {
        }
        
        public ObtenerResponseBody(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas[] ObtenerResult) {
            this.ObtenerResult = ObtenerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPorIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPorId", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequestBody Body;
        
        public ObtenerPorIdRequest() {
        }
        
        public ObtenerPorIdRequest(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerPorIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public ObtenerPorIdRequestBody() {
        }
        
        public ObtenerPorIdRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPorIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPorIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponseBody Body;
        
        public ObtenerPorIdResponse() {
        }
        
        public ObtenerPorIdResponse(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerPorIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas ObtenerPorIdResult;
        
        public ObtenerPorIdResponseBody() {
        }
        
        public ObtenerPorIdResponseBody(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas ObtenerPorIdResult) {
            this.ObtenerPorIdResult = ObtenerPorIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Agregar", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequestBody Body;
        
        public AgregarRequest() {
        }
        
        public AgregarRequest(WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p;
        
        public AgregarRequestBody() {
        }
        
        public AgregarRequestBody(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            this.p = p;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponseBody Body;
        
        public AgregarResponse() {
        }
        
        public AgregarResponse(WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AgregarResponseBody {
        
        public AgregarResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Editar", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequestBody Body;
        
        public EditarRequest() {
        }
        
        public EditarRequest(WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EditarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p;
        
        public EditarRequestBody() {
        }
        
        public EditarRequestBody(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            this.p = p;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditarResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponseBody Body;
        
        public EditarResponse() {
        }
        
        public EditarResponse(WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class EditarResponseBody {
        
        public EditarResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BorrarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Borrar", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequestBody Body;
        
        public BorrarRequest() {
        }
        
        public BorrarRequest(WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BorrarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p;
        
        public BorrarRequestBody() {
        }
        
        public BorrarRequestBody(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            this.p = p;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BorrarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BorrarResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponseBody Body;
        
        public BorrarResponse() {
        }
        
        public BorrarResponse(WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class BorrarResponseBody {
        
        public BorrarResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSPersonasSoapChannel : WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSPersonasSoapClient : System.ServiceModel.ClientBase<WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap>, WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap {
        
        public WSPersonasSoapClient() {
        }
        
        public WSPersonasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSPersonasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPersonasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPersonasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponse WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.Obtener(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest request) {
            return base.Channel.Obtener(request);
        }
        
        public WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas[] Obtener() {
            WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequestBody();
            WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponse retVal = ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).Obtener(inValue);
            return retVal.Body.ObtenerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponse> WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.ObtenerAsync(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest request) {
            return base.Channel.ObtenerAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerResponse> ObtenerAsync() {
            WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerRequestBody();
            return ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).ObtenerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponse WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.ObtenerPorId(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest request) {
            return base.Channel.ObtenerPorId(request);
        }
        
        public WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas ObtenerPorId(int id) {
            WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequestBody();
            inValue.Body.id = id;
            WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponse retVal = ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).ObtenerPorId(inValue);
            return retVal.Body.ObtenerPorIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponse> WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.ObtenerPorIdAsync(WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest request) {
            return base.Channel.ObtenerPorIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdResponse> ObtenerPorIdAsync(int id) {
            WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.ObtenerPorIdRequestBody();
            inValue.Body.id = id;
            return ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).ObtenerPorIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponse WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.Agregar(WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest request) {
            return base.Channel.Agregar(request);
        }
        
        public void Agregar(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequestBody();
            inValue.Body.p = p;
            WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponse retVal = ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).Agregar(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponse> WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.AgregarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest request) {
            return base.Channel.AgregarAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.AgregarResponse> AgregarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.AgregarRequestBody();
            inValue.Body.p = p;
            return ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).AgregarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponse WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.Editar(WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest request) {
            return base.Channel.Editar(request);
        }
        
        public void Editar(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequestBody();
            inValue.Body.p = p;
            WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponse retVal = ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).Editar(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponse> WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.EditarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest request) {
            return base.Channel.EditarAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.EditarResponse> EditarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.EditarRequestBody();
            inValue.Body.p = p;
            return ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).EditarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponse WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.Borrar(WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest request) {
            return base.Channel.Borrar(request);
        }
        
        public void Borrar(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequestBody();
            inValue.Body.p = p;
            WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponse retVal = ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).Borrar(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponse> WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap.BorrarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest request) {
            return base.Channel.BorrarAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClienteWSPersonas.ServiceReferenciaPersona.BorrarResponse> BorrarAsync(WebClienteWSPersonas.ServiceReferenciaPersona.EntPersonas p) {
            WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest inValue = new WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequest();
            inValue.Body = new WebClienteWSPersonas.ServiceReferenciaPersona.BorrarRequestBody();
            inValue.Body.p = p;
            return ((WebClienteWSPersonas.ServiceReferenciaPersona.WSPersonasSoap)(this)).BorrarAsync(inValue);
        }
    }
}
