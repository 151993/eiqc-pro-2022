using QSS.eIQC.DataAccess.Helpers.Claim;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using QSS.Models;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Domain;
using QSS.Common.Utilities.EntityFramework;
using QSS.Infrastructure.Exceptions;
using QSS.eIQC.Infrastucture.Core.Extensions;
using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.DataAccess.Helpers;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.DataAccess.DataContext
{
    public class QSSContext : DbContext, IQSSContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string InMemoryDatabaseProivder = "Microsoft.EntityFrameworkCore.InMemory";
        private const int TimeoutInSeconds = 600;

        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<WorkCell> WorkCell { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<SiteUser> SiteUser { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<CompletedGRS> CompletedGRS { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<UserCustomer> UserCustomer { get; set; }

        public virtual DbSet<CTParameter> CTParameter { get; set; }

        public virtual DbSet<SupplierForm> SupplierForm { get; set; }
        public virtual DbSet<SupplierFormVIS> SupplierFormVIS { get; set; }

        public virtual DbSet<UOM> UOM { get; set; }

        #region Auto Generated forms tables
        public virtual DbSet<GoodsReceiveUser> GoodsReceiveUser { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<InspectionToolsType> InspectionToolsType { get; set; }
        public virtual DbSet<InstrumentType> InstrumentType { get; set; }
        public virtual DbSet<GRSSAPResult> GRSSAPResult { get; set; }
        public virtual DbSet<LotInspectionQty> LotInspectionQty { get; set; }
        public virtual DbSet<ParameterType> ParameterType { get; set; }
        public virtual DbSet<PartCAF> PartCAF { get; set; }
        public virtual DbSet<PCCode> PCCode { get; set; }
        public virtual DbSet<ReceiveGoodsInfo> ReceiveGoodsInfo { get; set; }
        public virtual DbSet<ReceiveGoodsInfoManual> ReceiveGoodsInfoManual { get; set; }
        public virtual DbSet<Rosetta> Rosetta { get; set; }
        public virtual DbSet<DispositionType> DispositionType { get; set; }
        public virtual DbSet<ParameterCategory> ParameterCategory { get; set; }
        public virtual DbSet<SupplierFormCountParameter> SupplierFormCountParameter { get; set; }
        public virtual DbSet<SupplierTestReport> SupplierTestReport { get; set; }
        public virtual DbSet<SupplierFormSAPParameter> SupplierFormSAPParameter { get; set; }
        public virtual DbSet<SupplierFormBowTwistParameter> SupplierFormBowTwistParameter { get; set; }
        public virtual DbSet<SupplierFormSpecialParameter> SupplierFormSpecialParameter { get; set; }
        public virtual DbSet<SupplierFormResultOrientedParameter> SupplierFormResultOrientedParameter { get; set; }
        public virtual DbSet<SupplierFormPackaging> SupplierFormPackaging { get; set; }
        public virtual DbSet<SupplierFormPartDateCode> SupplierFormPartDateCode { get; set; }

        public virtual DbSet<SupplierFormBowTwistActual> SupplierFormBowTwistActual { get; set; }
        public virtual DbSet<SupplierFormFunPara> SupplierFormFunPara { get; set; }
        public virtual DbSet<SupplierFormFunParaActual> SupplierFormFunParaActual { get; set; }
        public virtual DbSet<SupplierFormLPosition> SupplierFormLPosition { get; set; }
        public virtual DbSet<SupplierFormLPositionActual> SupplierFormLPositionActual { get; set; }
        public virtual DbSet<SupplierFormMeasurementParameter> SupplierFormMeasurementParameter { get; set; }
        public virtual DbSet<SupplierFormMeasurementParameterActual> SupplierFormMeasurementParameterActual { get; set; }
        public virtual DbSet<SupplierFormMicroSection> SupplierFormMicroSection { get; set; }
        public virtual DbSet<SupplierFormMicroSectionActual> SupplierFormMicroSectionActual { get; set; }
        public virtual DbSet<SupplierFormMPosition> SupplierFormMPosition { get; set; }
        public virtual DbSet<SupplierFormMPositionActual> SupplierFormMPositionActual { get; set; }

        public virtual DbSet<SupplierAttachment> SupplierAttachment { get; set; }


        public virtual DbSet<Inspection> Inspection { get; set; }
        public virtual DbSet<InspectionTools> InspectionTools { get; set; }
        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<GRS> GRS { get; set; }
        public virtual DbSet<SAPPartInspectionPlan> SAPPartInspectionPlan { get; set; }
        public virtual DbSet<PCCodeInspectionToolsType> PCCodeInspectionToolsType { get; set; }
        public virtual DbSet<GRSSupplierForm> GRSSupplierForm { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<PartInspectionBowTwistParameter> PartInspectionBowTwistParameter { get; set; }
        public virtual DbSet<PartCountParameter> PartCountParameter { get; set; }

        public virtual DbSet<PartDateCode> PartDateCode { get; set; }
        public virtual DbSet<PartFunParameter> PartFunParameter { get; set; }
        public virtual DbSet<PartLPositionTolerance> PartLPositionTolerance { get; set; }
        public virtual DbSet<PartMeasurementParameter> PartMeasurementParameter { get; set; }
        public virtual DbSet<PartMicrosection> PartMicrosection { get; set; }
        public virtual DbSet<PartMPositionTolerance> PartMPositionTolerance { get; set; }
        public virtual DbSet<PartResultOrientedParameter> PartResultOrientedParameter { get; set; }
        public virtual DbSet<PartTestReportParameter> PartTestReportParameter { get; set; }

        public virtual DbSet<PartTestReportAttachment> PartTestReportAttachment { get; set; }

        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<FormBowTwistParameter> FormBowTwistParameter { get; set; }
        public virtual DbSet<FormCountParameter> FormCountParameter { get; set; }
        public virtual DbSet<FormFunPara> FormFunPara { get; set; }
        public virtual DbSet<FormFunParaActual> FormFunParaActual { get; set; }
        public virtual DbSet<FormLPosition> FormLPosition { get; set; }
        public virtual DbSet<FormLPositionActual> FormLPositionActual { get; set; }
        public virtual DbSet<FormMeasurementParameter> FormMeasurementParameter { get; set; }
        public virtual DbSet<FormMeasurementParameterActual> FormMeasurementParameterActual { get; set; }
        public virtual DbSet<FormBowTwistActual> FormBowTwistActual { get; set; }

        public virtual DbSet<FormMicroSection> FormMicroSection { get; set; }
        public virtual DbSet<FormMicroSectionActual> FormMicroSectionActual { get; set; }
        public virtual DbSet<FormMPosition> FormMPosition { get; set; }
        public virtual DbSet<FormMPositionActual> FormMPositionActual { get; set; }
        public virtual DbSet<FormPackaging> FormPackaging { get; set; }
        public virtual DbSet<FormPartDateCode> FormPartDateCode { get; set; }
        public virtual DbSet<FormPartSAPFailedQty> FormPartSAPFailedQty { get; set; }
        public virtual DbSet<FormResultOrientedParameter> FormResultOrientedParameter { get; set; }
        public virtual DbSet<FormSAPParameter> FormSAPParameter { get; set; }
        public virtual DbSet<FormSpecialParameter> FormSpecialParameter { get; set; }
        public virtual DbSet<FormStatus> FormStatus { get; set; }
        public virtual DbSet<FormTestReport> FormTestReport { get; set; }
        public virtual DbSet<FormVIS> FormVIS { get; set; }

        public virtual DbSet<FormType> FormType { get; set; }

        #endregion

        public virtual DbSet<TM1DataSyncDetails> TM1DataSyncDetails { get; set; }
        public virtual DbSet<Commodity> Commodity { get; set; }
        public virtual DbSet<AdminCertification> AdminCertification { get; set; }

        public virtual DbSet<AdminCertificationAttachment> AdminCertificationAttachment { get; set; }
        public virtual DbSet<SAPDataSyncDetails> SAPDataSyncDetails { get; set; }
        public virtual DbSet<MaterialGroup> MaterialGroup { get; set; }

        public virtual DbSet<PartInspectionDrawingAttachment> PartInspectionDrawingAttachment { get; set; }

        public virtual DbSet<PartInspectionSpecAttachment> PartInspectionSpecAttachment { get; set; }

        public virtual DbSet<PartInspectionCertificationAttachment> PartInspectionCertificationAttachment { get; set; }

        public virtual DbSet<ParameterManagement> ParameterManagement { get; set; }

        public virtual DbSet<ParameterManagementTypeModel> ParameterManagementType { get; set; }

        public virtual DbSet<DataTypeModel> DataType { get; set; }

        public virtual DbSet<ProductLifeCycleStageModel> ProductLifeCycleStage { get; set; }

        public virtual DbSet<ChartTypeModel> ChartType { get; set; }

        public virtual DbSet<TestReport> TestReport { get; set; }

        public virtual DbSet<ParameterTypeCode> ParameterTypeCode { get; set; }

        public virtual DbSet<ParameterTypePcCode> ParameterTypePcCode { get; set; }

        public virtual DbSet<PartDateCode> DateCode { get; set; }

        public virtual DbSet<WorkCellUser> WorkCellUser { get; set; }

        public virtual DbSet<WorkCellJabilUser> WorkCellJabilUser { get; set; }

        public virtual DbSet<WorkCellSite> WorkCellSite { get; set; }

        public virtual DbSet<TestReportCommodity> TestReportCommodity { get; set; }

        public virtual DbSet<ParameterManagementCommodity> ParameterManagementCommodity { get; set; }

        public virtual DbSet<SAPPartInspectionPlanAdminCertification> SAPPartInspectionPlanAdminCertification { get; set; }

        public virtual DbSet<SAPPartInspectionPlanSupplier> SAPPartInspectionPlanSupplier { get; set; }

        public virtual DbSet<PartDimension> PartDimension { get; set; }

        public virtual DbSet<BowTwistFormula> BowTwistFormula { get; set; }

        public virtual DbSet<WarPageModel> WarPage { get; set; }

        public virtual DbSet<DCCConfiguration> DCCConfiguration { get; set; }


        public virtual DbSet<CommodityCategory> CommodityCategory { get; set; }

        public virtual DbSet<CommodityPartNumberSite> CommodityPartNumberSite { get; set; }

        public virtual DbSet<Supplier> Supplier { get; set; }

        public virtual DbSet<PartInspectionDrawing> PartInspectionDrawing { get; set; }

        public virtual DbSet<PartInspectionSpecification> PartInspectionSpecification { get; set; }

        public virtual DbSet<SAPPartInspectionPlanComment> SAPPartInspectionPlanComment { get; set; }

        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<CertificateType> CertificateType { get; set; }

        public virtual DbSet<CertificateTypeParameter> CertificateTypeParameter { get; set; }

        public virtual DbSet<SupplierMeasurementSubmission> SupplierMeasurementSubmission { get; set; }

        public virtual DbSet<DefectManagement> DefectManagement { get; set; }

        public virtual DbSet<DefectSectionModel> DefectSection { get; set; }

        public virtual DbSet<DefectType> DefectType { get; set; }

        public virtual DbSet<SupplierMicrosection> SupplierMicrosection { get; set; }
        public virtual DbSet<SupplierDimensionMeasurement> SupplierDimensionMeasurement { get; set; }
        public virtual DbSet<SupplierFunctionVariable> SupplierFunctionVariable { get; set; }
        public virtual DbSet<SupplierFunctionVariableActual> SupplierFunctionVariableActual { get; set; }

        public virtual DbSet<SupplierSamplingPlan> SupplierSamplingPlan { get; set; }

        public virtual DbSet<SupplierDateCode> SupplierDateCode { get; set; }

        public virtual DbSet<SupplierMPosition> SupplierMPosition { get; set; }

        public virtual DbSet<DimensionDefault> DimensionDefault { get; set; }
        public virtual DbSet<SupplierVisualInspection> SupplierVisualInspection { get; set; }
        public virtual DbSet<SupplierVisualInspectionDefectType> SupplierVisualInspectionDefectType { get; set; }
        public virtual DbSet<SupplierDimensionMeasurementActual> SupplierDimensionMeasurementActual { get; set; }

        public virtual DbSet<SupplierLPosition> SupplierLPosition { get; set; }

        public virtual DbSet<RoleEnumModel> RoleEnum { get; set; }

        public virtual DbSet<SupplierMicroSectionActual> SupplierMicroSectionActual { get; set; }

        public virtual DbSet<SupplierBowTwistActual> SupplierBowTwistActual { get; set; }

        public virtual DbSet<SupplierMPositionActual> SupplierMPositionActual { get; set; }

        public virtual DbSet<SupplierLPositionActual> SupplierLPositionActual { get; set; }

        public virtual DbSet<SupplierFunctionAttributeActual> SupplierFunctionAttributeActual { get; set; }

        public virtual DbSet<SupplierBowTwist> SupplierBowTwist { get; set; }

        public virtual DbSet<SupplierFunctionAttribute> SupplierFunctionAttribute { get; set; }

        public virtual DbSet<SupplierSapBasedParameter> SupplierSapBasedParameter { get; set; }


        IDbContextTransaction CurrentTransaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMigrationContext"/> class.
        /// </summary>
        public QSSContext()
        {
            this.Database.SetCommandTimeout(TimeoutInSeconds);

        }




        /// <summary>
        /// Initializes a new instance of the <see cref="DataMigrationContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public QSSContext(DbContextOptions<QSSContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override int SaveChanges()
        {
            int recordsAffected;

            using (var currentTransaction = Database.BeginTransaction())
            {
                try
                {
                    int userId = GetUserId();

                    var trackables = ChangeTracker.Entries<IAuditedEntity>().ToArray();

                    var addedEntities = trackables.Where(t => t.State == EntityState.Added).ToList();

                    var modifiedEntities = trackables.Where(t => t.State == EntityState.Modified).ToList();

                    // modified
                    foreach (var item in modifiedEntities)
                    {
                        SetDefaultValues(item.Entity);
                        SetAuditLogForModified(item);
                    }

                    // added
                    foreach (var item in addedEntities)
                    {
                        SetDefaultValues(item.Entity, true);
                        SetAuditLog(item);
                    }

                    // deleted
                    foreach (var item in trackables.Where(t => t.State == EntityState.Deleted))
                    {
                        SetDefaultValues(item.Entity);
                        SetAuditLog(item);
                    }

                    recordsAffected = base.SaveChanges();

                    foreach (var item in addedEntities)
                    {
                        SetAuditLogId(item, EntityState.Added);
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    currentTransaction.Rollback();

                    // log error
                    throw new Exception(Constants.ErrorMessage.RecordAlreadyUpdated);
                }
                catch (DbUpdateException ex)
                {

                    if (ex.Source.Contains("Microsoft.EntityFrameworkCore.Relational"))
                    {
                        throw new UnableToDeleteException(Constants.ErrorMessage.UnableToDeleteRecord);
                    }
                    else if (((Npgsql.PostgresException)ex.InnerException).Code.Equals(Constants.PostgresErrorCode.PostgresUnableToDelete))
                    {
                        throw new UnableToDeleteException(Constants.ErrorMessage.UnableToDeleteRecord);
                    }
                    currentTransaction.Rollback();

                    // log error
                    throw;
                }
                catch (Exception ex)
                {
                    // log error
                    currentTransaction.Rollback();
                    throw;
                }

                currentTransaction.Commit();
            }


            return recordsAffected;
        }
        public int GetUserId()
        {
            if (Database.ProviderName.Equals(InMemoryDatabaseProivder) && _httpContextAccessor.HttpContext == null)
            {
                return Constants.DefaultUser.UserId;
            }
            var userIdentity = ClaimsTransformation.Transform(_httpContextAccessor.HttpContext.User);

            if (userIdentity.UserId > 0)
            {
                return User.FirstOrDefault(u => u.Email.ToLower() == userIdentity.Email.ToLower()).Id;
            }
            else
            {
                //1 is for System User
                return Constants.DefaultUser.UserId;
            }
            //return userIdentity.UserId;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(User).Assembly);
            SetIdentityStartValues(modelBuilder);
        }
        public void SetIdentityStartValues(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().Property(b => b.Id).HasIdentityOptions(startValue: Constants.IdentityStartValue.Role);
            modelBuilder.Entity<RolePermission>().Property(b => b.Id).HasIdentityOptions(startValue: Constants.IdentityStartValue.RolePermission);
            modelBuilder.Entity<User>().Property(b => b.Id).HasIdentityOptions(startValue: Constants.IdentityStartValue.User);
            modelBuilder.Entity<UserRole>().Property(b => b.Id).HasIdentityOptions(startValue: Constants.IdentityStartValue.UserRole);
            modelBuilder.Entity<Department>().Property(b => b.Id).HasIdentityOptions(startValue: Constants.IdentityStartValue.Department);
            modelBuilder.Entity<Manager>().Property(b => b.Id).HasIdentityOptions(startValue: Constants.IdentityStartValue.Manager);
        }
        public void BeginTransaction()
        {
            if (CurrentTransaction == null)
            {
                CurrentTransaction = Database.BeginTransaction();
            }
        }

        public void CommitTransaction(Exception exc = null)
        {
            CommitTransaction(() => SaveChanges(), exc);
        }
        private void CommitTransaction(Action commitAction, Exception exc)
        {
            try
            {
                if (CurrentTransaction != null && exc != null)
                {
                    CurrentTransaction.Rollback();
                    return;
                }

                commitAction();

                if (CurrentTransaction == null)
                {
                    return;
                }

                if (exc != null)
                {
                    CurrentTransaction.Rollback();
                }
                else
                {
                    CurrentTransaction.Commit();
                }
            }
            catch (Exception)
            {
                if (CurrentTransaction != null)
                {
                    CurrentTransaction.Rollback();
                }

                throw;
            }
            finally
            {
                if (CurrentTransaction != null)
                {
                    CurrentTransaction.Dispose();
                    CurrentTransaction = null;
                }
            }
        }

        private void SetDefaultValues(IAuditedEntity entity, bool isCreate = false)
        {
            var userId = GetUserId();


            if (isCreate)
            {
                entity.CreatedBy = userId;
            }
            entity.LastUpdatedBy = userId;
            entity.LastUpdated = DateTimeOffset.Now;
        }

        private void SetAuditLog(EntityEntry<IAuditedEntity> mainEntity)
        {
            if (mainEntity.Entity is IAuditLogEntity)
            {
                var entity = mainEntity.Entity as IAuditLogEntity;

                if (entity.AuditLog == null)
                {
                    return;
                }

                var modifiedFields = new List<AuditLogModifiedField>();
                var properties = entity.GetType().GetProperties();

                foreach (var prop in properties)
                {
                    var attributeValue = (AuditLogAttribute)Attribute.GetCustomAttribute(prop, typeof(AuditLogAttribute));

                    if (attributeValue != null)
                    {
                        var propertyName = string.IsNullOrEmpty(attributeValue.DisplayName) ? prop.Name : attributeValue.DisplayName;
                        var valueField = attributeValue.ValueField ?? prop.Name;
                        var value = string.Empty;

                        var oldValue = string.Empty;
                        var newValue = string.Empty;
                        string subPropertyName = string.Empty;
                        if (prop.PropertyType.IsGenericType)
                        {
                            value = string.Empty;
                            var propertyNames = valueField.Split('.');

                            var propName = propertyNames[0];

                            if (!prop.IsCollection())
                            {
                                subPropertyName = propertyNames[1];
                            }

                            //Load values
                            mainEntity.Navigation(prop.Name).Load();

                            //Get current value of the property
                            var propertyValues = mainEntity.Collection(prop.Name).CurrentValue;

                            var allValues = new List<string>();

                            //Iterate through the collection
                            foreach (var propvalue in propertyValues)
                            {
                                if (!prop.IsCollection())
                                {
                                    //Load values from database
                                    Entry(propvalue).Navigation(propName).Load();

                                    LoadChild(propertyNames, propvalue);

                                    //Get the current value of the property
                                    var subPropertyValue = Entry(propvalue).Navigation(propName).CurrentValue;


                                    //Find mapped sub property of class
                                    var subProperty = subPropertyValue.GetType().GetProperties().FirstOrDefault(p => p.Name == subPropertyName);

                                    allValues.Add(subProperty.GetValue(subPropertyValue)?.ToString());
                                }
                                else
                                {
                                    value = propvalue.GetPropValue(valueField)?.ToString();

                                    allValues.Add(value);
                                }
                            }

                            value = allValues.OrderBy(v => v).Aggregate((str1, str2) => $"{str1}, {str2}");
                        }
                        else if (!prop.PropertyType.IsEnum && prop.PropertyType.Namespace != "System")
                        {
                            var childProp = valueField.Split('.');

                            //Load values
                            mainEntity.Navigation(prop.Name).Load();

                            //Get current value of the property
                            var propertyValue = mainEntity.Reference(prop.Name).CurrentValue;

                            //Object has a nested child object then load all the child object upto n level depth
                            LoadChild(childProp, propertyValue);

                            //Find value of the class property, it's will resolve the child property also like Parent.Child.Property upto n level
                            var subProperty = propertyValue?.GetPropValue(valueField);

                            //Get the latest value of the mapped field
                            value = subProperty?.ToString();
                        }
                        else
                        {
                            value = prop.GetValue(entity)?.ToString();
                        }

                        oldValue = mainEntity.State == EntityState.Deleted ? value : null;
                        newValue = mainEntity.State == EntityState.Added ? value : null;

                        modifiedFields.Add(new AuditLogModifiedField()
                        {
                            FieldName = propertyName,
                            OldValue = oldValue,
                            NewValue = newValue
                        });
                    }
                }

                //No audit log columns modified just return
                if (!modifiedFields.IsAny())
                {
                    return;
                }

                var auditData = new AuditData()
                {
                    Metadata = new AuditMetadata()
                    {
                        Entity = new AuditMetadataEntity()
                        {
                            Name = mainEntity.Entity.GetType().Name,
                            Id = mainEntity.State == EntityState.Added ? string.Empty : ((IPersistentObject)mainEntity.Entity).Id.ToString()
                        }
                    },
                    LogData = new AuditLogData()
                    {
                        ModifiedFields = modifiedFields
                    }
                };

                entity.AuditLog.AuditData = auditData;

                SetDefaultValues(entity.AuditLog, true);

                if (mainEntity.State != EntityState.Added)
                {
                    AuditLog.Add(entity.AuditLog);
                }
            }
        }


        private void LoadChild(string[] childProp, object propertyValue)
        {
            if (childProp.Length > 1)
            {
                var prop = propertyValue;

                //Remove the last element from an array
                Array.Resize(ref childProp, childProp.Length - 1);

                foreach (var item in childProp)
                {
                    if (prop != null)
                    {
                        Entry(prop).Navigation(item).Load();
                        prop = Entry(prop).Navigation(item).CurrentValue;
                    }
                }
            }
        }


        private void SetAuditLogForModified(EntityEntry<IAuditedEntity> mainEntity)
        {
            if (mainEntity.Entity is IAuditLogEntity)
            {
                var entity = mainEntity.Entity as IAuditLogEntity;

                if (entity.AuditLog == null)
                {
                    return;
                }

                var modifiedFields = new List<AuditLogModifiedField>();
                var entityType = entity.GetType();
                var properties = entityType.GetProperties();

                //Get the old values for database
                var originialValues = mainEntity.GetDatabaseValues();

                foreach (var prop in properties)
                {
                    var attributes = Attribute.GetCustomAttributes(prop, typeof(AuditLogAttribute));
                    foreach (var attribute in attributes)
                    {
                        var attributeValue = (AuditLogAttribute)attribute;
                        if (attributeValue != null)
                        {
                            var oldValue = string.Empty;
                            var newValue = string.Empty;

                            var propertyName = string.IsNullOrEmpty(attributeValue.DisplayName) ? prop.Name : attributeValue.DisplayName;
                            var valueField = attributeValue.ValueField ?? prop.Name;


                            if (prop.IsVirtualAndGeneric())
                            {
                                var propertyNames = valueField.Split('.');

                                var propName = propertyNames[0];

                                var allValues = new List<string>();
                                var addedValues = new List<string>();
                                var removedValues = new List<string>();

                                var propertyCollection = prop.GetValue(entity) as IEnumerable<object>;

                                foreach (var propvalue in propertyCollection)
                                {

                                    if (IsNavigationLoaded(propName, propvalue))
                                    {

                                        //Object has a nested child object then load all the child object upto n level depth
                                        LoadChild(propertyNames, propvalue);
                                    }

                                    //Find value of the class, it's will resolve the child property also like Parent.Child.Property upto n level
                                    var value = propvalue.GetPropValue(valueField)?.ToString();

                                    if (propvalue is IAuditedEntity subEntity)
                                    {
                                        //If the Created Timestamp of the entity is MinValue then consider the record is just added
                                        if (subEntity.Created == DateTimeOffset.MinValue)
                                        {
                                            addedValues.Add(value);
                                        }
                                        else
                                        {
                                            removedValues.Add(value);
                                        }
                                    }
                                }

                                mainEntity.Navigation(prop.Name).Load();

                                //Get current value of the property
                                var AllPropertyCollection = mainEntity.Collection(prop.Name).CurrentValue;

                                foreach (var propvalue in AllPropertyCollection)
                                {

                                    if (IsNavigationLoaded(propName, propvalue))
                                    {
                                        //Object has a nested child object then load all the child object upto n level depth
                                        LoadChild(propertyNames, propvalue);
                                    }

                                    //Find value of the class, it's will resolve the child property also like Parent.Child.Property upto n level
                                    var value = propvalue.GetPropValue(valueField)?.ToString();

                                    //Get the latest value of the mapped field
                                    if (!allValues.Contains(value))
                                        allValues.Add(value);
                                }

                                //generate old and new value
                                oldValue = allValues.Where(v => !addedValues.Contains(v)).DefaultIfEmpty().OrderBy(v => v).Aggregate((str1, str2) => $"{str1}, {str2}");
                                newValue = allValues.Where(v => !removedValues.Contains(v)).DefaultIfEmpty().OrderBy(v => v).Aggregate((str1, str2) => $"{str1}, {str2}");
                            }
                            else if (!prop.PropertyType.IsEnum && prop.PropertyType.Namespace != "System")
                            {
                                var childProp = valueField.Split('.');
                                //Load values
                                mainEntity.Navigation(prop.Name).Load();

                                //Get current value of the property
                                var propertyValue = mainEntity.Navigation(prop.Name).CurrentValue;

                                //Object has a nested child object then load all the child object upto n level depth
                                LoadChild(childProp, propertyValue);

                                //Find value of the class, it's will resolve the child property also like Parent.Child.Property upto n level
                                var subProperty = propertyValue?.GetPropValue(valueField);

                                //Get the latest value of the mapped field
                                newValue = subProperty?.ToString();

                                var dbValue = originialValues.GetValue<object>(attributeValue.MappingField);

                                var oldEntity = Find(prop.PropertyType, dbValue);

                                //Object has a nested child object then load all the child object upto n level depth
                                LoadChild(childProp, oldEntity);
                                oldValue = oldEntity?.GetPropValue(valueField)?.ToString();
                            }
                            else
                            {
                                var fkAttributeName = prop.GetFkNameFromAttribute();
                                var propName = prop.PropertyType.IsEnum && fkAttributeName != null ? fkAttributeName : prop.Name;

                                oldValue = prop.PropertyType.IsEnum && fkAttributeName != null
                                                ? Enum.Parse(prop.PropertyType, originialValues.GetValue<object>(propName)?.ToString())?.ToString()
                                                : originialValues.GetValue<object>(propName)?.ToString();

                                newValue = prop.GetValue(entity)?.ToString();
                            }

                            if (oldValue != newValue)
                            {
                                modifiedFields.Add(new AuditLogModifiedField()
                                {
                                    FieldName = propertyName,
                                    OldValue = oldValue,
                                    NewValue = newValue
                                });
                            }
                        }
                    }
                }

                if (!modifiedFields.IsAny())
                {
                    return;
                }

                var auditData = new AuditData()
                {
                    Metadata = new AuditMetadata()
                    {
                        Entity = new AuditMetadataEntity()
                        {
                            Name = mainEntity.Entity.GetType().Name,
                            Id = ((IPersistentObject)mainEntity.Entity).Id.ToString()
                        }
                    },
                    LogData = new AuditLogData()
                    {
                        ModifiedFields = modifiedFields
                    }
                };

                entity.AuditLog.AuditData = auditData;

                SetDefaultValues(entity.AuditLog, true);

                AuditLog.Add(entity.AuditLog);
            }
        }

        private bool IsNavigationLoaded(string propName, object propvalue)
        {
            try
            {
                //Load the valu from DB
                Entry(propvalue).Navigation(propName).Load();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void SetAuditLogId(EntityEntry<IAuditedEntity> mainEntity, EntityState state)
        {
            if (mainEntity.Entity is IAuditLogEntity)
            {
                var entity = mainEntity.Entity as IAuditLogEntity;

                if (entity.AuditLog == null)
                {
                    return;
                }

                entity.AuditLog.AuditData.Metadata.Entity.Id = ((IPersistentObject)mainEntity.Entity).Id.ToString();

                AuditLog.Add(entity.AuditLog);

                base.SaveChanges();
            }
        }

    }
}
