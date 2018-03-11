﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JCDecauxSoapClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contract", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxSoapGateway")]
    [System.SerializableAttribute()]
    public partial class Contract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string commercial_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string commercial_name {
            get {
                return this.commercial_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.commercial_nameField, value) != true)) {
                    this.commercial_nameField = value;
                    this.RaisePropertyChanged("commercial_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/JCDecauxSoapGateway")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int available_bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int available_bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bankingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bonusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contract_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double latField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double lngField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int available_bike_stands {
            get {
                return this.available_bike_standsField;
            }
            set {
                if ((this.available_bike_standsField.Equals(value) != true)) {
                    this.available_bike_standsField = value;
                    this.RaisePropertyChanged("available_bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int available_bikes {
            get {
                return this.available_bikesField;
            }
            set {
                if ((this.available_bikesField.Equals(value) != true)) {
                    this.available_bikesField = value;
                    this.RaisePropertyChanged("available_bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool banking {
            get {
                return this.bankingField;
            }
            set {
                if ((this.bankingField.Equals(value) != true)) {
                    this.bankingField = value;
                    this.RaisePropertyChanged("banking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bike_stands {
            get {
                return this.bike_standsField;
            }
            set {
                if ((this.bike_standsField.Equals(value) != true)) {
                    this.bike_standsField = value;
                    this.RaisePropertyChanged("bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bonus {
            get {
                return this.bonusField;
            }
            set {
                if ((this.bonusField.Equals(value) != true)) {
                    this.bonusField = value;
                    this.RaisePropertyChanged("bonus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contract_name {
            get {
                return this.contract_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.contract_nameField, value) != true)) {
                    this.contract_nameField = value;
                    this.RaisePropertyChanged("contract_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long last_update {
            get {
                return this.last_updateField;
            }
            set {
                if ((this.last_updateField.Equals(value) != true)) {
                    this.last_updateField = value;
                    this.RaisePropertyChanged("last_update");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double lat {
            get {
                return this.latField;
            }
            set {
                if ((this.latField.Equals(value) != true)) {
                    this.latField = value;
                    this.RaisePropertyChanged("lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double lng {
            get {
                return this.lngField;
            }
            set {
                if ((this.lngField.Equals(value) != true)) {
                    this.lngField = value;
                    this.RaisePropertyChanged("lng");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISoapGateway")]
    public interface ISoapGateway {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapGateway/GetContracts", ReplyAction="http://tempuri.org/ISoapGateway/GetContractsResponse")]
        JCDecauxSoapClient.ServiceReference1.Contract[] GetContracts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapGateway/GetContracts", ReplyAction="http://tempuri.org/ISoapGateway/GetContractsResponse")]
        System.Threading.Tasks.Task<JCDecauxSoapClient.ServiceReference1.Contract[]> GetContractsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapGateway/GetStations", ReplyAction="http://tempuri.org/ISoapGateway/GetStationsResponse")]
        JCDecauxSoapClient.ServiceReference1.Station[] GetStations(JCDecauxSoapClient.ServiceReference1.Contract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapGateway/GetStations", ReplyAction="http://tempuri.org/ISoapGateway/GetStationsResponse")]
        System.Threading.Tasks.Task<JCDecauxSoapClient.ServiceReference1.Station[]> GetStationsAsync(JCDecauxSoapClient.ServiceReference1.Contract contract);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISoapGatewayChannel : JCDecauxSoapClient.ServiceReference1.ISoapGateway, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SoapGatewayClient : System.ServiceModel.ClientBase<JCDecauxSoapClient.ServiceReference1.ISoapGateway>, JCDecauxSoapClient.ServiceReference1.ISoapGateway {
        
        public SoapGatewayClient() {
        }
        
        public SoapGatewayClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SoapGatewayClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoapGatewayClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoapGatewayClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public JCDecauxSoapClient.ServiceReference1.Contract[] GetContracts() {
            return base.Channel.GetContracts();
        }
        
        public System.Threading.Tasks.Task<JCDecauxSoapClient.ServiceReference1.Contract[]> GetContractsAsync() {
            return base.Channel.GetContractsAsync();
        }
        
        public JCDecauxSoapClient.ServiceReference1.Station[] GetStations(JCDecauxSoapClient.ServiceReference1.Contract contract) {
            return base.Channel.GetStations(contract);
        }
        
        public System.Threading.Tasks.Task<JCDecauxSoapClient.ServiceReference1.Station[]> GetStationsAsync(JCDecauxSoapClient.ServiceReference1.Contract contract) {
            return base.Channel.GetStationsAsync(contract);
        }
    }
}
