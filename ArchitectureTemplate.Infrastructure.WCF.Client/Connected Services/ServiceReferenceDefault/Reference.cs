﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScreenContract", Namespace="http://schemas.datacontract.org/2004/07/ArchitectureTemplate.Infrastructure.WCF.D" +
        "efault.Entities")]
    [System.SerializableAttribute()]
    public partial class ScreenContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ControllerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DeleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForScreenContract[] ProfileForScreenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool UpdateField;
        
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
        public string ControllerName {
            get {
                return this.ControllerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ControllerNameField, value) != true)) {
                    this.ControllerNameField = value;
                    this.RaisePropertyChanged("ControllerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Delete {
            get {
                return this.DeleteField;
            }
            set {
                if ((this.DeleteField.Equals(value) != true)) {
                    this.DeleteField = value;
                    this.RaisePropertyChanged("Delete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForScreenContract[] ProfileForScreen {
            get {
                return this.ProfileForScreenField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileForScreenField, value) != true)) {
                    this.ProfileForScreenField = value;
                    this.RaisePropertyChanged("ProfileForScreen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Read {
            get {
                return this.ReadField;
            }
            set {
                if ((this.ReadField.Equals(value) != true)) {
                    this.ReadField = value;
                    this.RaisePropertyChanged("Read");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Update {
            get {
                return this.UpdateField;
            }
            set {
                if ((this.UpdateField.Equals(value) != true)) {
                    this.UpdateField = value;
                    this.RaisePropertyChanged("Update");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfileForScreenContract", Namespace="http://schemas.datacontract.org/2004/07/ArchitectureTemplate.Infrastructure.WCF.D" +
        "efault.Entities")]
    [System.SerializableAttribute()]
    public partial class ProfileForScreenContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CreateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DeleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileContract ProfileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfileIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract ScreenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ScreenIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool UpdateField;
        
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
        public bool Create {
            get {
                return this.CreateField;
            }
            set {
                if ((this.CreateField.Equals(value) != true)) {
                    this.CreateField = value;
                    this.RaisePropertyChanged("Create");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Delete {
            get {
                return this.DeleteField;
            }
            set {
                if ((this.DeleteField.Equals(value) != true)) {
                    this.DeleteField = value;
                    this.RaisePropertyChanged("Delete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileContract Profile {
            get {
                return this.ProfileField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileField, value) != true)) {
                    this.ProfileField = value;
                    this.RaisePropertyChanged("Profile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProfileId {
            get {
                return this.ProfileIdField;
            }
            set {
                if ((this.ProfileIdField.Equals(value) != true)) {
                    this.ProfileIdField = value;
                    this.RaisePropertyChanged("ProfileId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Read {
            get {
                return this.ReadField;
            }
            set {
                if ((this.ReadField.Equals(value) != true)) {
                    this.ReadField = value;
                    this.RaisePropertyChanged("Read");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract Screen {
            get {
                return this.ScreenField;
            }
            set {
                if ((object.ReferenceEquals(this.ScreenField, value) != true)) {
                    this.ScreenField = value;
                    this.RaisePropertyChanged("Screen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ScreenId {
            get {
                return this.ScreenIdField;
            }
            set {
                if ((this.ScreenIdField.Equals(value) != true)) {
                    this.ScreenIdField = value;
                    this.RaisePropertyChanged("ScreenId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Update {
            get {
                return this.UpdateField;
            }
            set {
                if ((this.UpdateField.Equals(value) != true)) {
                    this.UpdateField = value;
                    this.RaisePropertyChanged("Update");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfileContract", Namespace="http://schemas.datacontract.org/2004/07/ArchitectureTemplate.Infrastructure.WCF.D" +
        "efault.Entities")]
    [System.SerializableAttribute()]
    public partial class ProfileContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AtivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCadastroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForMenuContract[] ProfileForMenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForScreenContract[] ProfileForScreenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SolicitanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.UserContract[] UserField;
        
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
        public bool Ativo {
            get {
                return this.AtivoField;
            }
            set {
                if ((this.AtivoField.Equals(value) != true)) {
                    this.AtivoField = value;
                    this.RaisePropertyChanged("Ativo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCadastro {
            get {
                return this.DataCadastroField;
            }
            set {
                if ((this.DataCadastroField.Equals(value) != true)) {
                    this.DataCadastroField = value;
                    this.RaisePropertyChanged("DataCadastro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForMenuContract[] ProfileForMenu {
            get {
                return this.ProfileForMenuField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileForMenuField, value) != true)) {
                    this.ProfileForMenuField = value;
                    this.RaisePropertyChanged("ProfileForMenu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForScreenContract[] ProfileForScreen {
            get {
                return this.ProfileForScreenField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileForScreenField, value) != true)) {
                    this.ProfileForScreenField = value;
                    this.RaisePropertyChanged("ProfileForScreen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Solicitante {
            get {
                return this.SolicitanteField;
            }
            set {
                if ((object.ReferenceEquals(this.SolicitanteField, value) != true)) {
                    this.SolicitanteField = value;
                    this.RaisePropertyChanged("Solicitante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.UserContract[] User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfileForMenuContract", Namespace="http://schemas.datacontract.org/2004/07/ArchitectureTemplate.Infrastructure.WCF.D" +
        "efault.Entities")]
    [System.SerializableAttribute()]
    public partial class ProfileForMenuContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.MenuContract MenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MenuIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileContract ProfileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfileIdField;
        
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
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.MenuContract Menu {
            get {
                return this.MenuField;
            }
            set {
                if ((object.ReferenceEquals(this.MenuField, value) != true)) {
                    this.MenuField = value;
                    this.RaisePropertyChanged("Menu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MenuId {
            get {
                return this.MenuIdField;
            }
            set {
                if ((this.MenuIdField.Equals(value) != true)) {
                    this.MenuIdField = value;
                    this.RaisePropertyChanged("MenuId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileContract Profile {
            get {
                return this.ProfileField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileField, value) != true)) {
                    this.ProfileField = value;
                    this.RaisePropertyChanged("Profile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProfileId {
            get {
                return this.ProfileIdField;
            }
            set {
                if ((this.ProfileIdField.Equals(value) != true)) {
                    this.ProfileIdField = value;
                    this.RaisePropertyChanged("ProfileId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserContract", Namespace="http://schemas.datacontract.org/2004/07/ArchitectureTemplate.Infrastructure.WCF.D" +
        "efault.Entities")]
    [System.SerializableAttribute()]
    public partial class UserContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AtivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfileIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
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
        public bool Ativo {
            get {
                return this.AtivoField;
            }
            set {
                if ((this.AtivoField.Equals(value) != true)) {
                    this.AtivoField = value;
                    this.RaisePropertyChanged("Ativo");
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
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProfileId {
            get {
                return this.ProfileIdField;
            }
            set {
                if ((this.ProfileIdField.Equals(value) != true)) {
                    this.ProfileIdField = value;
                    this.RaisePropertyChanged("ProfileId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MenuContract", Namespace="http://schemas.datacontract.org/2004/07/ArchitectureTemplate.Infrastructure.WCF.D" +
        "efault.Entities")]
    [System.SerializableAttribute()]
    public partial class MenuContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForMenuContract[] ProfileForMenuField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ProfileForMenuContract[] ProfileForMenu {
            get {
                return this.ProfileForMenuField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileForMenuField, value) != true)) {
                    this.ProfileForMenuField = value;
                    this.RaisePropertyChanged("ProfileForMenu");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDefault.IServiceContract")]
    public interface IServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetById", ReplyAction="http://tempuri.org/IServiceContract/GetByIdResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetById", ReplyAction="http://tempuri.org/IServiceContract/GetByIdResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetByName", ReplyAction="http://tempuri.org/IServiceContract/GetByNameResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract GetByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetByName", ReplyAction="http://tempuri.org/IServiceContract/GetByNameResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract> GetByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetScreensByContains", ReplyAction="http://tempuri.org/IServiceContract/GetScreensByContainsResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[] GetScreensByContains(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetScreensByContains", ReplyAction="http://tempuri.org/IServiceContract/GetScreensByContainsResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[]> GetScreensByContainsAsync(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetScreensByRange", ReplyAction="http://tempuri.org/IServiceContract/GetScreensByRangeResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[] GetScreensByRange(int idBegin, int idEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/GetScreensByRange", ReplyAction="http://tempuri.org/IServiceContract/GetScreensByRangeResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[]> GetScreensByRangeAsync(int idBegin, int idEnd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceContractChannel : ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.IServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceContractClient : System.ServiceModel.ClientBase<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.IServiceContract>, ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.IServiceContract {
        
        public ServiceContractClient() {
        }
        
        public ServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract GetByName(string name) {
            return base.Channel.GetByName(name);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract> GetByNameAsync(string name) {
            return base.Channel.GetByNameAsync(name);
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[] GetScreensByContains(string key) {
            return base.Channel.GetScreensByContains(key);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[]> GetScreensByContainsAsync(string key) {
            return base.Channel.GetScreensByContainsAsync(key);
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[] GetScreensByRange(int idBegin, int idEnd) {
            return base.Channel.GetScreensByRange(idBegin, idEnd);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceDefault.ScreenContract[]> GetScreensByRangeAsync(int idBegin, int idEnd) {
            return base.Channel.GetScreensByRangeAsync(idBegin, idEnd);
        }
    }
}
