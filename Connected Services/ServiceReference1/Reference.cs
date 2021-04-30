﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaymentOrders.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentOrder", Namespace="http://schemas.datacontract.org/2004/07/WebApp.Models")]
    [System.SerializableAttribute()]
    public partial class PaymentOrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrigConIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaymentNotesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PaymentOrders.ServiceReference1.Recipient RecipientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RecipientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PaymentOrders.ServiceReference1.Remitter RemitterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RemitterIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PaymentOrders.ServiceReference1.Transaction TransactionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TransactionIDField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrigConID {
            get {
                return this.OrigConIDField;
            }
            set {
                if ((object.ReferenceEquals(this.OrigConIDField, value) != true)) {
                    this.OrigConIDField = value;
                    this.RaisePropertyChanged("OrigConID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaymentNotes {
            get {
                return this.PaymentNotesField;
            }
            set {
                if ((object.ReferenceEquals(this.PaymentNotesField, value) != true)) {
                    this.PaymentNotesField = value;
                    this.RaisePropertyChanged("PaymentNotes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PaymentOrders.ServiceReference1.Recipient Recipient {
            get {
                return this.RecipientField;
            }
            set {
                if ((object.ReferenceEquals(this.RecipientField, value) != true)) {
                    this.RecipientField = value;
                    this.RaisePropertyChanged("Recipient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RecipientID {
            get {
                return this.RecipientIDField;
            }
            set {
                if ((this.RecipientIDField.Equals(value) != true)) {
                    this.RecipientIDField = value;
                    this.RaisePropertyChanged("RecipientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PaymentOrders.ServiceReference1.Remitter Remitter {
            get {
                return this.RemitterField;
            }
            set {
                if ((object.ReferenceEquals(this.RemitterField, value) != true)) {
                    this.RemitterField = value;
                    this.RaisePropertyChanged("Remitter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RemitterID {
            get {
                return this.RemitterIDField;
            }
            set {
                if ((this.RemitterIDField.Equals(value) != true)) {
                    this.RemitterIDField = value;
                    this.RaisePropertyChanged("RemitterID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PaymentOrders.ServiceReference1.Transaction Transaction {
            get {
                return this.TransactionField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionField, value) != true)) {
                    this.TransactionField = value;
                    this.RaisePropertyChanged("Transaction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TransactionID {
            get {
                return this.TransactionIDField;
            }
            set {
                if ((this.TransactionIDField.Equals(value) != true)) {
                    this.TransactionIDField = value;
                    this.RaisePropertyChanged("TransactionID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Recipient", Namespace="http://schemas.datacontract.org/2004/07/WebApp.Models")]
    [System.SerializableAttribute()]
    public partial class Recipient : PaymentOrders.ServiceReference1.ValueObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FinancialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstitutionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MCCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriAccField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PurposeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ccyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Financial {
            get {
                return this.FinancialField;
            }
            set {
                if ((object.ReferenceEquals(this.FinancialField, value) != true)) {
                    this.FinancialField = value;
                    this.RaisePropertyChanged("Financial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdNo {
            get {
                return this.IdNoField;
            }
            set {
                if ((object.ReferenceEquals(this.IdNoField, value) != true)) {
                    this.IdNoField = value;
                    this.RaisePropertyChanged("IdNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdType {
            get {
                return this.IdTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.IdTypeField, value) != true)) {
                    this.IdTypeField = value;
                    this.RaisePropertyChanged("IdType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstitutionID {
            get {
                return this.InstitutionIDField;
            }
            set {
                if ((object.ReferenceEquals(this.InstitutionIDField, value) != true)) {
                    this.InstitutionIDField = value;
                    this.RaisePropertyChanged("InstitutionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MCC {
            get {
                return this.MCCField;
            }
            set {
                if ((this.MCCField.Equals(value) != true)) {
                    this.MCCField = value;
                    this.RaisePropertyChanged("MCC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PriAcc {
            get {
                return this.PriAccField;
            }
            set {
                if ((object.ReferenceEquals(this.PriAccField, value) != true)) {
                    this.PriAccField = value;
                    this.RaisePropertyChanged("PriAcc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Purpose {
            get {
                return this.PurposeField;
            }
            set {
                if ((object.ReferenceEquals(this.PurposeField, value) != true)) {
                    this.PurposeField = value;
                    this.RaisePropertyChanged("Purpose");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ccy {
            get {
                return this.ccyField;
            }
            set {
                if ((this.ccyField.Equals(value) != true)) {
                    this.ccyField = value;
                    this.RaisePropertyChanged("ccy");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Remitter", Namespace="http://schemas.datacontract.org/2004/07/WebApp.Models")]
    [System.SerializableAttribute()]
    public partial class Remitter : PaymentOrders.ServiceReference1.ValueObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FinancialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FundsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ccyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string principalActivityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Financial {
            get {
                return this.FinancialField;
            }
            set {
                if ((object.ReferenceEquals(this.FinancialField, value) != true)) {
                    this.FinancialField = value;
                    this.RaisePropertyChanged("Financial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Funds {
            get {
                return this.FundsField;
            }
            set {
                if ((object.ReferenceEquals(this.FundsField, value) != true)) {
                    this.FundsField = value;
                    this.RaisePropertyChanged("Funds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdNo {
            get {
                return this.IdNoField;
            }
            set {
                if ((object.ReferenceEquals(this.IdNoField, value) != true)) {
                    this.IdNoField = value;
                    this.RaisePropertyChanged("IdNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdType {
            get {
                return this.IdTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.IdTypeField, value) != true)) {
                    this.IdTypeField = value;
                    this.RaisePropertyChanged("IdType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ccy {
            get {
                return this.ccyField;
            }
            set {
                if ((this.ccyField.Equals(value) != true)) {
                    this.ccyField = value;
                    this.RaisePropertyChanged("ccy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string principalActivity {
            get {
                return this.principalActivityField;
            }
            set {
                if ((object.ReferenceEquals(this.principalActivityField, value) != true)) {
                    this.principalActivityField = value;
                    this.RaisePropertyChanged("principalActivity");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Transaction", Namespace="http://schemas.datacontract.org/2004/07/WebApp.Models")]
    [System.SerializableAttribute()]
    public partial class Transaction : PaymentOrders.ServiceReference1.ValueObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemTraceANOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string routeIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reference {
            get {
                return this.ReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceField, value) != true)) {
                    this.ReferenceField = value;
                    this.RaisePropertyChanged("Reference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemTraceANO {
            get {
                return this.SystemTraceANOField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemTraceANOField, value) != true)) {
                    this.SystemTraceANOField = value;
                    this.RaisePropertyChanged("SystemTraceANO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string routeID {
            get {
                return this.routeIDField;
            }
            set {
                if ((object.ReferenceEquals(this.routeIDField, value) != true)) {
                    this.routeIDField = value;
                    this.RaisePropertyChanged("routeID");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValueObject", Namespace="http://schemas.datacontract.org/2004/07/WebApp.Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PaymentOrders.ServiceReference1.Remitter))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PaymentOrders.ServiceReference1.Transaction))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PaymentOrders.ServiceReference1.Recipient))]
    public partial class ValueObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        PaymentOrders.ServiceReference1.PaymentOrder[] GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<PaymentOrders.ServiceReference1.PaymentOrder[]> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FindPaymentOrder", ReplyAction="http://tempuri.org/IService/FindPaymentOrderResponse")]
        PaymentOrders.ServiceReference1.PaymentOrder FindPaymentOrder(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FindPaymentOrder", ReplyAction="http://tempuri.org/IService/FindPaymentOrderResponse")]
        System.Threading.Tasks.Task<PaymentOrders.ServiceReference1.PaymentOrder> FindPaymentOrderAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPaymentOrder", ReplyAction="http://tempuri.org/IService/AddPaymentOrderResponse")]
        void AddPaymentOrder(PaymentOrders.ServiceReference1.PaymentOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPaymentOrder", ReplyAction="http://tempuri.org/IService/AddPaymentOrderResponse")]
        System.Threading.Tasks.Task AddPaymentOrderAsync(PaymentOrders.ServiceReference1.PaymentOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EditPaymentOrder", ReplyAction="http://tempuri.org/IService/EditPaymentOrderResponse")]
        void EditPaymentOrder(PaymentOrders.ServiceReference1.PaymentOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EditPaymentOrder", ReplyAction="http://tempuri.org/IService/EditPaymentOrderResponse")]
        System.Threading.Tasks.Task EditPaymentOrderAsync(PaymentOrders.ServiceReference1.PaymentOrder order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : PaymentOrders.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<PaymentOrders.ServiceReference1.IService>, PaymentOrders.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PaymentOrders.ServiceReference1.PaymentOrder[] GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<PaymentOrders.ServiceReference1.PaymentOrder[]> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public PaymentOrders.ServiceReference1.PaymentOrder FindPaymentOrder(System.Nullable<int> id) {
            return base.Channel.FindPaymentOrder(id);
        }
        
        public System.Threading.Tasks.Task<PaymentOrders.ServiceReference1.PaymentOrder> FindPaymentOrderAsync(System.Nullable<int> id) {
            return base.Channel.FindPaymentOrderAsync(id);
        }
        
        public void AddPaymentOrder(PaymentOrders.ServiceReference1.PaymentOrder order) {
            base.Channel.AddPaymentOrder(order);
        }
        
        public System.Threading.Tasks.Task AddPaymentOrderAsync(PaymentOrders.ServiceReference1.PaymentOrder order) {
            return base.Channel.AddPaymentOrderAsync(order);
        }
        
        public void EditPaymentOrder(PaymentOrders.ServiceReference1.PaymentOrder order) {
            base.Channel.EditPaymentOrder(order);
        }
        
        public System.Threading.Tasks.Task EditPaymentOrderAsync(PaymentOrders.ServiceReference1.PaymentOrder order) {
            return base.Channel.EditPaymentOrderAsync(order);
        }
    }
}
