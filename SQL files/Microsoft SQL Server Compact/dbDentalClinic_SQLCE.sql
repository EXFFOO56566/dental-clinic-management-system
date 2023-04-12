CREATE TABLE [Voucher] (
  [VOUCHER_ID] bigint IDENTITY (1,1) NOT NULL
, [CHART_OF_ACCOUNT_ID] bigint NULL
, [DateOfVoucher] datetime NULL
, [ReferenceNumber] nvarchar(500) NULL
, [Remark] ntext NULL
, [Amount] float NULL
, [PaymentMethod] nvarchar(254) NULL
);
GO
CREATE TABLE [UserPermission] (
  [FormCaption] nvarchar(254) NULL
, [FormName] nvarchar(254) NULL
, [UserID] bigint NULL
, [Active] bit NULL
);
GO
CREATE TABLE [TreatmentSickLeave] (
  [VID] bigint NULL
, [ReferenceNo] nvarchar(254) NULL
, [ApplicationDate] datetime NULL
, [PatientName] nvarchar(500) NULL
, [Age] nvarchar(254) NULL
, [LeaveFrom] datetime NULL
, [LeaveTo] datetime NULL
, [Disease] ntext NULL
, [DateDuration] nvarchar(254) NULL
);
GO
CREATE TABLE [TreatmentProcedure] (
  [TRMPDC_ID] bigint IDENTITY (1,1) NOT NULL
, [VID] bigint NULL
, [PrescribedProcedure] ntext NULL
, [Remarks] ntext NULL
, [Price] float DEFAULT ((0)) NULL
);
GO
CREATE TABLE [TreatmentDisease] (
  [TDS_ID] bigint IDENTITY (1,1) NOT NULL
, [Disease] ntext NULL
, [Diagnosis] ntext NULL
, [VID] bigint NULL
);
GO
CREATE TABLE [Treatment] (
  [VID] bigint IDENTITY (1,1) NOT NULL
, [VisitingDate] datetime NULL
, [VisitingTime] nvarchar(254) NULL
, [AppointmentNo] bigint NULL
, [Patient_ID] bigint NULL
, [PatientName] nvarchar(254) NULL
, [PatientAge] nvarchar(254) NULL
, [Gender] nvarchar(254) NULL
, [CompliantSymptoms] ntext NULL
, [PreviousDentalHistory] ntext NULL
, [PastMedicalHistory] ntext NULL
, [DentalHygienists] bit NULL
, [GumDisease] bit NULL
, [KeepingBadHabitsCheck] bit NULL
, [PlaqueTartarCavities] bit NULL
, [RoutineCheckUp] bit NULL
, [Accident] bit NULL
, [OralCancerDetection] bit NULL
, [Development] bit NULL
, [AestheticsOrthodontics] bit NULL
, [NextAppointment] bit NULL
, [NextAppointmentDate] nvarchar(254) NULL
, [SubTotal] float DEFAULT ((0)) NULL
, [Discount] float DEFAULT ((0)) NULL
, [TAX] float DEFAULT ((0)) NULL
, [Total] float DEFAULT ((0)) NULL
, [Paid] float DEFAULT ((0)) NULL
, [ChangeDue] float DEFAULT ((0)) NULL
);
GO
CREATE TABLE [ProductInformation] (
  [PRODUCT_ID] bigint IDENTITY (1,1) NOT NULL
, [ProductName] nvarchar(500) NULL
, [GenericName] nvarchar(500) NULL
, [CATEGORY_ID] bigint DEFAULT ((0)) NULL
, [ManufactureDate] datetime NULL
, [ExpirationDate] datetime NULL
, [Barcode] nvarchar(500) NULL
, [UOM] nvarchar(254) NULL
, [Quantity] float NULL
, [PurchasePrice] float NULL
, [SalesPrice] float NULL
, [Photo_File_Name] nvarchar(254) NULL
);
GO
CREATE TABLE [ProductCategory] (
  [CATEGORY_ID] bigint IDENTITY (1,1) NOT NULL
, [CATEGORY_NAME] nvarchar(250) NULL
);
GO
CREATE TABLE [PrescriptionDetail] (
  [PCD_ID] bigint IDENTITY (1,1) NOT NULL
, [PRESCRIPTION_ID] bigint NULL
, [MedicineName] ntext NULL
, [Dodge] nvarchar(254) NULL
, [Duration] nvarchar(254) NULL
, [Qty] nvarchar(254) NULL
, [Remark] ntext NULL
);
GO
CREATE TABLE [Prescription] (
  [PRESCRIPTION_ID] bigint IDENTITY (1,1) NOT NULL
, [PrescriptionDate] datetime NULL
, [AppointmentNo] nvarchar(254) NULL
, [VisitID] nvarchar(254) NULL
, [Patient_ID] bigint NULL
, [PatientName] ntext NULL
, [Age] nvarchar(254) NULL
, [Gender] nvarchar(254) NULL
);
GO
CREATE TABLE [PhysiciansInformation] (
  [DOCTOR_ID] bigint IDENTITY (1,1) NOT NULL
, [DoctorName] nvarchar(500) NULL
, [Speciality] nvarchar(500) NULL
, [Qualification] nvarchar(500) NULL
, [Address] ntext NULL
, [ContactNumber] nvarchar(500) NULL
, [CommencementDate] datetime NULL
);
GO
CREATE TABLE [PharmacyBillingDetails] (
  [ID] bigint IDENTITY (1,1) NOT NULL
, [BILL_NO] bigint NULL
, [PRODUCT_ID] bigint NULL
, [Qty] float NULL
, [UnitCost] float NULL
, [UnitSales] float NULL
, [TotalCost] float NULL
, [TotalSales] float NULL
);
GO
CREATE TABLE [PharmacyBilling] (
  [BILL_NO] bigint IDENTITY (1,1) NOT NULL
, [BILLING_DATE] datetime NULL
, [Patient_ID] bigint NULL
, [WalkInCustomerName] nvarchar(500) NULL
, [Total] float NULL
, [Paid_PAYMENT] float NULL
, [DUE_PAYMENT] float NULL
, [PAYMENT_METHOD] nvarchar(254) NULL
);
GO
CREATE TABLE [PatientInformation] (
  [Patient_ID] bigint IDENTITY (1,1) NOT NULL
, [PatientName] nvarchar(500) NULL
, [ParentNames] nvarchar(500) NULL
, [Gender] nvarchar(254) NULL
, [Age] nvarchar(254) NULL
, [Occupation] nvarchar(500) NULL
, [Address] ntext NULL
, [ContactNo] nvarchar(500) NULL
, [Reference] nvarchar(500) NULL
, [DateOfEnroll] datetime NULL
, [Photo_File_Name] nvarchar(254) NULL
);
GO
CREATE TABLE [DiseaseDiagnosis] (
  [DISEASE_DIAGNOSIS_ID] bigint IDENTITY (1,1) NOT NULL
, [Disease] ntext NULL
);
GO
CREATE TABLE [DentalProcedures] (
  [PROCEDURES_ID] bigint IDENTITY (1,1) NOT NULL
, [DENTAL_PROCEDURES] nvarchar(500) NULL
, [PRICE] float NULL
);
GO
CREATE TABLE [DentalNotation] (
  [ctrlName] nvarchar(254) NULL
, [DentalNo] nvarchar(254) NULL
, [DentalNotation] nvarchar(254) NULL
, [DentalTypes] nvarchar(254) NULL
);
GO
CREATE TABLE [ClinicInformation] (
  [ClinicName] nvarchar(500) NULL
, [Phone] nvarchar(500) NULL
, [Address] ntext NULL
, [ReportHeader] ntext NULL
, [ReportFooter] ntext NULL
, [Clinic_Logo] ntext NULL
);
GO
CREATE TABLE [ChartOfAccounts] (
  [CHART_OF_ACCOUNT_ID] bigint IDENTITY (1,1) NOT NULL
, [AccountsName] nvarchar(500) NULL
, [AccountsType] nvarchar(500) NULL
, [AcStatus] nvarchar(254) NULL
);
GO
CREATE TABLE [ApplicationUsers] (
  [UserID] bigint IDENTITY (1,1) NOT NULL
, [FullName] nvarchar(500) NULL
, [UserName] nvarchar(500) NULL
, [Password] nvarchar(500) NULL
, [ContactNo] nvarchar(500) NULL
, [UserType] nvarchar(500) NULL
, [JoiningDate] datetime NULL
, [RegistrationDate] datetime NULL
, [LastLogonDateTime] datetime NULL
, [Photo_File_Name] ntext NULL
, [Designation] nvarchar(500) NULL
);
GO
ALTER TABLE [Voucher] ADD CONSTRAINT [PK__Voucher__60E7A0B3173876EA] PRIMARY KEY ([VOUCHER_ID]);
GO
ALTER TABLE [TreatmentProcedure] ADD CONSTRAINT [PK__Treatmen__1A80ED7C300424B4] PRIMARY KEY ([TRMPDC_ID]);
GO
ALTER TABLE [TreatmentDisease] ADD CONSTRAINT [PK__Treatmen__5D4C3E8C37A5467C] PRIMARY KEY ([TDS_ID]);
GO
ALTER TABLE [Treatment] ADD CONSTRAINT [PK__Treatmen__C5DF22BB276EDEB3] PRIMARY KEY ([VID]);
GO
ALTER TABLE [ProductCategory] ADD CONSTRAINT [PK__ProductC__E7DA297C09DE7BCC] PRIMARY KEY ([CATEGORY_ID]);
GO
ALTER TABLE [PrescriptionDetail] ADD CONSTRAINT [PK__Prescrip__B1EF791549C3F6B7] PRIMARY KEY ([PCD_ID]);
GO
ALTER TABLE [Prescription] ADD CONSTRAINT [PK__Prescrip__83756B5F4222D4EF] PRIMARY KEY ([PRESCRIPTION_ID]);
GO
ALTER TABLE [PhysiciansInformation] ADD CONSTRAINT [PK__Physicia__596ABDB00DAF0CB0] PRIMARY KEY ([DOCTOR_ID]);
GO
ALTER TABLE [PharmacyBillingDetails] ADD CONSTRAINT [PK__Pharmacy__3214EC271ED998B2] PRIMARY KEY ([ID]);
GO
ALTER TABLE [PharmacyBilling] ADD CONSTRAINT [PK__Pharmacy__0856FE9F1B0907CE] PRIMARY KEY ([BILL_NO]);
GO
ALTER TABLE [PatientInformation] ADD CONSTRAINT [PK__Patient__C1A88B597F60ED59] PRIMARY KEY ([Patient_ID]);
GO
ALTER TABLE [DiseaseDiagnosis] ADD CONSTRAINT [PK__DiseaseD__121D104833D4B598] PRIMARY KEY ([DISEASE_DIAGNOSIS_ID]);
GO
ALTER TABLE [DentalProcedures] ADD CONSTRAINT [PK__DentalPr__EA14109F239E4DCF] PRIMARY KEY ([PROCEDURES_ID]);
GO
ALTER TABLE [ChartOfAccounts] ADD CONSTRAINT [PK__ChartOfA__83960DB71367E606] PRIMARY KEY ([CHART_OF_ACCOUNT_ID]);
GO
ALTER TABLE [ApplicationUsers] ADD CONSTRAINT [PK__Applicat__1788CCAC0519C6AF] PRIMARY KEY ([UserID]);
GO

