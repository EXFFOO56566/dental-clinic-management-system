USE [dbDentalClinic]
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[VOUCHER_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[CHART_OF_ACCOUNT_ID] [bigint] NULL,
	[DateOfVoucher] [date] NULL,
	[ReferenceNumber] [nvarchar](500) NULL,
	[Remark] [text] NULL,
	[Amount] [float] NULL,
	[PaymentMethod] [nvarchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[VOUCHER_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserPermission]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPermission](
	[FormCaption] [nvarchar](254) NULL,
	[FormName] [nvarchar](254) NULL,
	[UserID] [bigint] NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TreatmentSickLeave]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreatmentSickLeave](
	[VID] [bigint] NULL,
	[ReferenceNo] [nvarchar](254) NULL,
	[ApplicationDate] [date] NULL,
	[PatientName] [nvarchar](500) NULL,
	[Age] [nvarchar](254) NULL,
	[LeaveFrom] [date] NULL,
	[LeaveTo] [date] NULL,
	[Disease] [text] NULL,
	[DateDuration] [nvarchar](254) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TreatmentProcedure]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreatmentProcedure](
	[TRMPDC_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[VID] [bigint] NULL,
	[PrescribedProcedure] [text] NULL,
	[Remarks] [text] NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[TRMPDC_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TreatmentDisease]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreatmentDisease](
	[TDS_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Disease] [text] NULL,
	[Diagnosis] [text] NULL,
	[VID] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[TDS_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Treatment]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment](
	[VID] [bigint] IDENTITY(1,1) NOT NULL,
	[VisitingDate] [date] NULL,
	[VisitingTime] [nvarchar](254) NULL,
	[AppointmentNo] [bigint] NULL,
	[Patient_ID] [bigint] NULL,
	[PatientName] [nvarchar](254) NULL,
	[PatientAge] [nvarchar](254) NULL,
	[Gender] [nvarchar](254) NULL,
	[CompliantSymptoms] [text] NULL,
	[PreviousDentalHistory] [text] NULL,
	[PastMedicalHistory] [text] NULL,
	[DentalHygienists] [bit] NULL,
	[GumDisease] [bit] NULL,
	[KeepingBadHabitsCheck] [bit] NULL,
	[PlaqueTartarCavities] [bit] NULL,
	[RoutineCheckUp] [bit] NULL,
	[Accident] [bit] NULL,
	[OralCancerDetection] [bit] NULL,
	[Development] [bit] NULL,
	[AestheticsOrthodontics] [bit] NULL,
	[NextAppointment] [bit] NULL,
	[NextAppointmentDate] [nvarchar](254) NULL,
	[SubTotal] [float] NULL,
	[Discount] [float] NULL,
	[TAX] [float] NULL,
	[Total] [float] NULL,
	[Paid] [float] NULL,
	[ChangeDue] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[VID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInformation]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInformation](
	[PRODUCT_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](500) NULL,
	[GenericName] [nvarchar](500) NULL,
	[CATEGORY_ID] [bigint] NULL,
	[ManufactureDate] [date] NULL,
	[ExpirationDate] [date] NULL,
	[Barcode] [nvarchar](500) NULL,
	[UOM] [nvarchar](254) NULL,
	[Quantity] [float] NULL,
	[PurchasePrice] [float] NULL,
	[SalesPrice] [float] NULL,
	[Photo_File_Name] [nvarchar](254) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[CATEGORY_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[CATEGORY_NAME] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[CATEGORY_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrescriptionDetail]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrescriptionDetail](
	[PCD_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PRESCRIPTION_ID] [bigint] NULL,
	[MedicineName] [text] NULL,
	[Dodge] [nvarchar](254) NULL,
	[Duration] [nvarchar](254) NULL,
	[Qty] [nvarchar](254) NULL,
	[Remark] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[PCD_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescription]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[PRESCRIPTION_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PrescriptionDate] [date] NULL,
	[AppointmentNo] [nvarchar](254) NULL,
	[VisitID] [nvarchar](254) NULL,
	[Patient_ID] [bigint] NULL,
	[PatientName] [text] NULL,
	[Age] [nvarchar](254) NULL,
	[Gender] [nvarchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[PRESCRIPTION_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhysiciansInformation]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhysiciansInformation](
	[DOCTOR_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[DoctorName] [nvarchar](500) NULL,
	[Speciality] [nvarchar](500) NULL,
	[Qualification] [nvarchar](500) NULL,
	[Address] [text] NULL,
	[ContactNumber] [nvarchar](500) NULL,
	[CommencementDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[DOCTOR_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PharmacyBillingDetails]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PharmacyBillingDetails](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[BILL_NO] [bigint] NULL,
	[PRODUCT_ID] [bigint] NULL,
	[Qty] [float] NULL,
	[UnitCost] [float] NULL,
	[UnitSales] [float] NULL,
	[TotalCost] [float] NULL,
	[TotalSales] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PharmacyBilling]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PharmacyBilling](
	[BILL_NO] [bigint] IDENTITY(1,1) NOT NULL,
	[BILLING_DATE] [date] NULL,
	[Patient_ID] [bigint] NULL,
	[WalkInCustomerName] [nvarchar](500) NULL,
	[Total] [float] NULL,
	[Paid_PAYMENT] [float] NULL,
	[DUE_PAYMENT] [float] NULL,
	[PAYMENT_METHOD] [nvarchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[BILL_NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientInformation]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientInformation](
	[Patient_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PatientName] [nvarchar](500) NULL,
	[ParentNames] [nvarchar](500) NULL,
	[Gender] [nvarchar](254) NULL,
	[Age] [nvarchar](254) NULL,
	[Occupation] [nvarchar](500) NULL,
	[Address] [text] NULL,
	[ContactNo] [nvarchar](500) NULL,
	[Reference] [nvarchar](500) NULL,
	[DateOfEnroll] [date] NULL,
	[Photo_File_Name] [nvarchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[Patient_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiseaseDiagnosis]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiseaseDiagnosis](
	[DISEASE_DIAGNOSIS_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Disease] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[DISEASE_DIAGNOSIS_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DentalProcedures]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DentalProcedures](
	[PROCEDURES_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[DENTAL_PROCEDURES] [nvarchar](500) NULL,
	[PRICE] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[PROCEDURES_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DentalNotation]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DentalNotation](
	[ctrlName] [varchar](254) NULL,
	[DentalNo] [nvarchar](254) NULL,
	[DentalNotation] [nvarchar](254) NULL,
	[DentalTypes] [nvarchar](254) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClinicInformation]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicInformation](
	[ClinicName] [nvarchar](500) NULL,
	[Phone] [nvarchar](500) NULL,
	[Address] [text] NULL,
	[ReportHeader] [text] NULL,
	[ReportFooter] [text] NULL,
	[Clinic_Logo] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChartOfAccounts]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChartOfAccounts](
	[CHART_OF_ACCOUNT_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[AccountsName] [nvarchar](500) NULL,
	[AccountsType] [nvarchar](500) NULL,
	[AcStatus] [nvarchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[CHART_OF_ACCOUNT_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationUsers]    Script Date: 12/26/2019 20:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUsers](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](500) NULL,
	[UserName] [nvarchar](500) NULL,
	[Password] [nvarchar](500) NULL,
	[ContactNo] [nvarchar](500) NULL,
	[UserType] [nvarchar](500) NULL,
	[JoiningDate] [date] NULL,
	[RegistrationDate] [date] NULL,
	[LastLogonDateTime] [datetime] NULL,
	[Photo_File_Name] [text] NULL,
	[Designation] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Default [DF__ProductIn__CATEG__108B795B]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[ProductInformation] ADD  DEFAULT ((0)) FOR [CATEGORY_ID]
GO
/****** Object:  Default [DF_Treatment_SubTotal]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[Treatment] ADD  CONSTRAINT [DF_Treatment_SubTotal]  DEFAULT ((0)) FOR [SubTotal]
GO
/****** Object:  Default [DF_Treatment_Discount]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[Treatment] ADD  CONSTRAINT [DF_Treatment_Discount]  DEFAULT ((0)) FOR [Discount]
GO
/****** Object:  Default [DF_Treatment_TAX]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[Treatment] ADD  CONSTRAINT [DF_Treatment_TAX]  DEFAULT ((0)) FOR [TAX]
GO
/****** Object:  Default [DF_Treatment_Total]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[Treatment] ADD  CONSTRAINT [DF_Treatment_Total]  DEFAULT ((0)) FOR [Total]
GO
/****** Object:  Default [DF_Treatment_Paid]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[Treatment] ADD  CONSTRAINT [DF_Treatment_Paid]  DEFAULT ((0)) FOR [Paid]
GO
/****** Object:  Default [DF_Treatment_ChangeDue]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[Treatment] ADD  CONSTRAINT [DF_Treatment_ChangeDue]  DEFAULT ((0)) FOR [ChangeDue]
GO
/****** Object:  Default [DF_TreatmentProcedure_Price]    Script Date: 12/26/2019 20:16:00 ******/
ALTER TABLE [dbo].[TreatmentProcedure] ADD  CONSTRAINT [DF_TreatmentProcedure_Price]  DEFAULT ((0)) FOR [Price]
GO
