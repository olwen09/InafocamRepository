using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inafocam.core.Modelos
{
    public partial class inafocam_tracingContext : DbContext
    {
        public inafocam_tracingContext()
        {
        }

        public inafocam_tracingContext(DbContextOptions<inafocam_tracingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<AgentType> AgentType { get; set; }
        public virtual DbSet<AgreementType> AgreementType { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Communication> Communication { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyType> CompanyType { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactAddress> ContactAddress { get; set; }
        public virtual DbSet<ContactCommunication> ContactCommunication { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<EducationType> EducationType { get; set; }
        public virtual DbSet<File> File { get; set; }
        public virtual DbSet<FileType> FileType { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuType> MenuType { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<ObjectMapping> ObjectMapping { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleDay> ScheduleDay { get; set; }
        public virtual DbSet<ScholarshipLevel> ScholarshipLevel { get; set; }
        public virtual DbSet<ScholarshipProgram> ScholarshipProgram { get; set; }
        public virtual DbSet<ScholarshipProgramTracing> ScholarshipProgramTracing { get; set; }
        public virtual DbSet<ScholarshipProgramTracingAgreement> ScholarshipProgramTracingAgreement { get; set; }
        public virtual DbSet<ScholarshipProgramTracingAgreementFile> ScholarshipProgramTracingAgreementFile { get; set; }
        public virtual DbSet<ScholarshipProgramTracingCourse> ScholarshipProgramTracingCourse { get; set; }
        public virtual DbSet<ScholarshipProgramTracingCourseFile> ScholarshipProgramTracingCourseFile { get; set; }
        public virtual DbSet<ScholarshipProgramTracingCourseFileType> ScholarshipProgramTracingCourseFileType { get; set; }
        public virtual DbSet<ScholarshipProgramTracingPractice> ScholarshipProgramTracingPractice { get; set; }
        public virtual DbSet<ScholarshipProgramTracingPracticePlanning> ScholarshipProgramTracingPracticePlanning { get; set; }
        public virtual DbSet<ScholarshipProgramTracingQualitySystem> ScholarshipProgramTracingQualitySystem { get; set; }
        public virtual DbSet<ScholarshipProgramTracingQualitySystemFileType> ScholarshipProgramTracingQualitySystemFileType { get; set; }
        public virtual DbSet<ScholarshipProgramTracingStudentPractice> ScholarshipProgramTracingStudentPractice { get; set; }
        public virtual DbSet<ScholarshipProgramTracingStudentSupport> ScholarshipProgramTracingStudentSupport { get; set; }
        public virtual DbSet<ScholarshipProgramUniversity> ScholarshipProgramUniversity { get; set; }
        public virtual DbSet<ScholarshipProgramUniversityAgent> ScholarshipProgramUniversityAgent { get; set; }
        public virtual DbSet<ScholarshipProgramUniversityAgreement> ScholarshipProgramUniversityAgreement { get; set; }
        public virtual DbSet<ScholarshipProgramUniversitySubjectMatter> ScholarshipProgramUniversitySubjectMatter { get; set; }
        public virtual DbSet<ScholarshipProgramUniversityTeacherHiring> ScholarshipProgramUniversityTeacherHiring { get; set; }
        public virtual DbSet<SpuTaughtSubject> SpuTaughtSubject { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StudyPlanManagement> StudyPlanManagement { get; set; }
        public virtual DbSet<SubjectMatter> SubjectMatter { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherEducation> TeacherEducation { get; set; }
        public virtual DbSet<TeacherFile> TeacherFile { get; set; }
        public virtual DbSet<TeacherFileType> TeacherFileType { get; set; }
        public virtual DbSet<TeacherHiringType> TeacherHiringType { get; set; }
        public virtual DbSet<TeacherResearch> TeacherResearch { get; set; }
        public virtual DbSet<TracingStudyPlanDevelopment> TracingStudyPlanDevelopment { get; set; }
        public virtual DbSet<University> University { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserMapRole> UserMapRole { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserRolePermission> UserRolePermission { get; set; }
        public virtual DbSet<UserUniversity> UserUniversity { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3305;user=root;password=123456;database=inafocam_tracing");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.HasIndex(e => e.AddressTypeId)
                    .HasName("FK_address_address_type");

                entity.HasIndex(e => e.CityId)
                    .HasName("FK_address_city");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_address_user");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("FK_address_province");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_address_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_address_user_2");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.AddressTypeId).HasColumnName("address_type_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.HomeNumber)
                    .HasColumnName("home_number")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("FK_address_address_type");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_address_city");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.AddressCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_address_user");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_address_province");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_address_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.AddressUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_address_user_2");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("address_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_address_type_status");

                entity.Property(e => e.AddressTypeId).HasColumnName("address_type_id");

                entity.Property(e => e.AddressTypeName)
                    .HasColumnName("address_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AddressType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_address_type_status");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("agent");

                entity.HasIndex(e => e.AgentTypeId)
                    .HasName("FK_agent_agent_type");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_cordinator_user");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_cordinator_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_cordinator_user_2");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_agent_user");

                entity.Property(e => e.AgentId).HasColumnName("agent_id");

                entity.Property(e => e.AgentTypeId).HasColumnName("agent_type_id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.AgentType)
                    .WithMany(p => p.Agent)
                    .HasForeignKey(d => d.AgentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_agent_agent_type");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.AgentCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_cordinator_user");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Agent)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_cordinator_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.AgentUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_cordinator_user_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AgentUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_agent_user");
            });

            modelBuilder.Entity<AgentType>(entity =>
            {
                entity.ToTable("agent_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_agent_type_status");

                entity.Property(e => e.AgentTypeId).HasColumnName("agent_type_id");

                entity.Property(e => e.AgentTypeName)
                    .HasColumnName("agent_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AgentType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_agent_type_status");
            });

            modelBuilder.Entity<AgreementType>(entity =>
            {
                entity.ToTable("agreement_type");

                entity.Property(e => e.AgreementTypeId).HasColumnName("agreement_type_id");

                entity.Property(e => e.AgreementPanelClass)
                    .HasColumnName("agreement_panel_class")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AgreementTypeName)
                    .HasColumnName("agreement_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.HasIndex(e => e.CountryId)
                    .HasName("FK_city_country");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("FK_city_province");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_city_status");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CityShortName)
                    .HasColumnName("city_short_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_city_country");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_city_province");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_city_status");
            });

            modelBuilder.Entity<Communication>(entity =>
            {
                entity.ToTable("communication");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_communication_user");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_communication_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_communication_user_2");

                entity.Property(e => e.CommunicationId).HasColumnName("communication_id");

                entity.Property(e => e.CommunicationEmail)
                    .HasColumnName("communication_email")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationPhoneNumber1)
                    .HasColumnName("communication_phone_number1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationPhoneNumber2)
                    .HasColumnName("communication_phone_number2")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationWebsite)
                    .HasColumnName("communication_website")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.CommunicationCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_communication_user");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Communication)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_communication_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.CommunicationUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_communication_user_2");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.HasIndex(e => e.AddressId)
                    .HasName("FK_company_address");

                entity.HasIndex(e => e.CommunicationId)
                    .HasName("FK_company_communication");

                entity.HasIndex(e => e.CompanyTypeId)
                    .HasName("FK_company_company_type");

                entity.HasIndex(e => e.ContactId)
                    .HasName("FK_company_contact");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_company_user_3");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("FK_company_user");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("FK_company_user_2");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_company_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_company_user_4");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CommunicationId).HasColumnName("communication_id");

                entity.Property(e => e.CompanyTypeId).HasColumnName("company_type_id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_company_address");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_company_communication");

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.CompanyTypeId)
                    .HasConstraintName("FK_company_company_type");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_company_contact");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.CompanyCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_company_user_3");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.CompanyManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_company_user");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.CompanyOwner)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK_company_user_2");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_company_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.CompanyUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_company_user_4");
            });

            modelBuilder.Entity<CompanyType>(entity =>
            {
                entity.ToTable("company_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_company_type_status");

                entity.Property(e => e.CompanyTypeId).HasColumnName("company_type_id");

                entity.Property(e => e.CompanyTypeName)
                    .HasColumnName("company_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CompanyType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_company_type_status");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.HasIndex(e => e.ContactDocumentNumber)
                    .HasName("contact_document_number")
                    .IsUnique();

                entity.HasIndex(e => e.ContactTypeId)
                    .HasName("FK_contact_contact_type");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_contact_user");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("FK_contact_document_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_contact_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_contact_user_2");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.ContactBornDate)
                    .HasColumnName("contact_born_date")
                    .HasColumnType("date");

                entity.Property(e => e.ContactBornPlace)
                    .HasColumnName("contact_born_place")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ContactComment)
                    .HasColumnName("contact_comment")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDocumentNumber)
                    .HasColumnName("contact_document_number")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ContactGender)
                    .HasColumnName("contact_gender")
                    .HasColumnType("enum('female','male','none')");

                entity.Property(e => e.ContactJobInformationId).HasColumnName("contact_job_information_id");

                entity.Property(e => e.ContactLastname)
                    .HasColumnName("contact_lastname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ContactMaritalStatusId).HasColumnName("contact_marital_status_id");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNationalityId).HasColumnName("contact_nationality_id");

                entity.Property(e => e.ContactTypeId).HasColumnName("contact_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_contact_contact_type");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.ContactCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_contact_user");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("FK_contact_document_type");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_contact_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.ContactUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_contact_user_2");
            });

            modelBuilder.Entity<ContactAddress>(entity =>
            {
                entity.ToTable("contact_address");

                entity.HasIndex(e => e.AddressId)
                    .HasName("FK_contact_address_address");

                entity.HasIndex(e => e.ContactId)
                    .HasName("FK_contact_address_contact");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_contact_address_status");

                entity.Property(e => e.ContactAddressId).HasColumnName("contact_address_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.ContactAddressComment)
                    .HasColumnName("contact_address_comment")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ContactAddress)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_contact_address_address");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactAddress)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_contact_address_contact");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ContactAddress)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_contact_address_status");
            });

            modelBuilder.Entity<ContactCommunication>(entity =>
            {
                entity.ToTable("contact_communication");

                entity.HasIndex(e => e.CommunicationId)
                    .HasName("FK_contact_communication_communication");

                entity.HasIndex(e => e.ContactId)
                    .HasName("FK_contact_communication_contact");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_contact_communication_status");

                entity.Property(e => e.ContactCommunicationId).HasColumnName("contact_communication_id");

                entity.Property(e => e.CommunicationId).HasColumnName("communication_id");

                entity.Property(e => e.ContactCommunicationComment)
                    .HasColumnName("contact_communication_comment")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.ContactCommunication)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_contact_communication_communication");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactCommunication)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_contact_communication_contact");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ContactCommunication)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_contact_communication_status");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("contact_type");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("FK_contact_type_document_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_contact_type_status");

                entity.Property(e => e.ContactTypeId).HasColumnName("contact_type_id");

                entity.Property(e => e.ContactTypeName)
                    .HasColumnName("contact_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.ContactType)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("FK_contact_type_document_type");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ContactType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_contact_type_status");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_country_status");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CountryShortName)
                    .HasColumnName("country_short_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_country_status");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("document_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_document_type_status");

                entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.DocumentTypeName)
                    .HasColumnName("document_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypePattern)
                    .HasColumnName("document_type_pattern")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DocumentType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_document_type_status");
            });

            modelBuilder.Entity<EducationType>(entity =>
            {
                entity.ToTable("education_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_education_type_status");

                entity.Property(e => e.EducationTypeId).HasColumnName("education_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.EducationTypeName)
                    .HasColumnName("education_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.EducationType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_education_type_status");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.ToTable("file");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_file_user");

                entity.HasIndex(e => e.FileTypeId)
                    .HasName("FK_file_file_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_file_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_file_user_2");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.FileApplicationType)
                    .HasColumnName("file_application_type")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FileFullPath)
                    .HasColumnName("file_full_path")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeId).HasColumnName("file_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.FileCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_file_user");

                entity.HasOne(d => d.FileType)
                    .WithMany(p => p.File)
                    .HasForeignKey(d => d.FileTypeId)
                    .HasConstraintName("FK_file_file_type");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.File)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_file_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.FileUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_file_user_2");
            });

            modelBuilder.Entity<FileType>(entity =>
            {
                entity.ToTable("file_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_file_type_status");

                entity.Property(e => e.FileTypeId).HasColumnName("file_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.FileTypeName)
                    .HasColumnName("file_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.FileType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_file_type_status");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("marital_status");

                entity.Property(e => e.MaritalStatusId).HasColumnName("marital_status_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.MaritalStatusName)
                    .HasColumnName("marital_status_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.HasIndex(e => e.MenuParentId)
                    .HasName("FK_menu_menu");

                entity.HasIndex(e => e.MenuTypeId)
                    .HasName("FK_menu_menu_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_menu_status");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.MenuCaption)
                    .HasColumnName("menu_caption")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MenuIcon)
                    .HasColumnName("menu_icon")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MenuLink)
                    .HasColumnName("menu_link")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MenuParentId).HasColumnName("menu_parent_id");

                entity.Property(e => e.MenuPosition).HasColumnName("menu_position");

                entity.Property(e => e.MenuTypeId).HasColumnName("menu_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.MenuParent)
                    .WithMany(p => p.InverseMenuParent)
                    .HasForeignKey(d => d.MenuParentId)
                    .HasConstraintName("FK_menu_menu");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("FK_menu_menu_type");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_menu_status");
            });

            modelBuilder.Entity<MenuType>(entity =>
            {
                entity.ToTable("menu_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_menu_type_status");

                entity.Property(e => e.MenuTypeId).HasColumnName("menu_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.MenuTypeName)
                    .HasColumnName("menu_type_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MenuType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_menu_type_status");
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration)
                    .IsRequired()
                    .HasColumnName("migration")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("nationality");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.NationalityName)
                    .HasColumnName("nationality_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.ToTable("object");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_object_status");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Object)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_object_status");
            });

            modelBuilder.Entity<ObjectMapping>(entity =>
            {
                entity.ToTable("object_mapping");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("FK_object_mapping_object");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_object_mapping_status");

                entity.Property(e => e.ObjectMappingId).HasColumnName("object_mapping_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectMappingName)
                    .HasColumnName("object_mapping_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.ObjectMapping)
                    .HasForeignKey(d => d.ObjectId)
                    .HasConstraintName("FK_object_mapping_object");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ObjectMapping)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_object_mapping_status");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("office");

                entity.HasIndex(e => e.AddressId)
                    .HasName("FK_office_address");

                entity.HasIndex(e => e.CommunicationId)
                    .HasName("FK_office_communication");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FK_office_company");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_office_user_2");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("FK_office_user");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_office_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_office_user_3");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CommunicationId).HasColumnName("communication_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.OfficeName)
                    .HasColumnName("office_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_office_address");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_office_communication");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_office_company");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.OfficeCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_office_user_2");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.OfficeManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_office_user");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_office_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.OfficeUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_office_user_3");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("province");

                entity.HasIndex(e => e.CountryId)
                    .HasName("FK_province_country");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_province_status");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("province_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_province_country");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_province_status");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("schedule");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_schedule_user");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_schedule_status");

                entity.HasIndex(e => e.UpdatingUserId)
                    .HasName("FK_schedule_user_2");

                entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.ScheduleName)
                    .HasColumnName("schedule_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpdatingDate).HasColumnName("updating_date");

                entity.Property(e => e.UpdatingUserId).HasColumnName("updating_user_id");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.ScheduleCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_schedule_user");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_schedule_status");

                entity.HasOne(d => d.UpdatingUser)
                    .WithMany(p => p.ScheduleUpdatingUser)
                    .HasForeignKey(d => d.UpdatingUserId)
                    .HasConstraintName("FK_schedule_user_2");
            });

            modelBuilder.Entity<ScheduleDay>(entity =>
            {
                entity.ToTable("schedule_day");

                entity.HasIndex(e => e.ScheduleId)
                    .HasName("FK_schedule_days_schedule");

                entity.Property(e => e.ScheduleDayId).HasColumnName("schedule_day_id");

                entity.Property(e => e.ScheduleDay1)
                    .HasColumnName("schedule_day")
                    .HasColumnType("enum('SUNDAY','MONDAY')");

                entity.Property(e => e.ScheduleEndTime).HasColumnName("schedule_end_time");

                entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");

                entity.Property(e => e.ScheduleStartTime).HasColumnName("schedule_start_time");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleDay)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_schedule_days_schedule");
            });

            modelBuilder.Entity<ScholarshipLevel>(entity =>
            {
                entity.ToTable("scholarship_level");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_level_status");

                entity.Property(e => e.ScholarshipLevelId).HasColumnName("scholarship_level_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.ScholarshipLevelName)
                    .HasColumnName("scholarship_level_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipLevel)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_level_status");
            });

            modelBuilder.Entity<ScholarshipProgram>(entity =>
            {
                entity.ToTable("scholarship_program");

                entity.HasIndex(e => e.ScholarshipLevelId)
                    .HasName("FK_scholarship_program_scholarship_level");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_status");

                entity.Property(e => e.ScholarshipProgramId).HasColumnName("scholarship_program_id");

                entity.Property(e => e.CreationDate).HasColumnName(" creation_date");

                entity.Property(e => e.ScholarshipLevelId).HasColumnName("scholarship_level_id");

                entity.Property(e => e.ScholarshipProgramName)
                    .HasColumnName("scholarship_program_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.ScholarshipLevel)
                    .WithMany(p => p.ScholarshipProgram)
                    .HasForeignKey(d => d.ScholarshipLevelId)
                    .HasConstraintName("FK_scholarship_program_scholarship_level");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgram)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_status");
            });

            modelBuilder.Entity<ScholarshipProgramTracing>(entity =>
            {
                entity.ToTable("scholarship_program_tracing");

                entity.HasIndex(e => e.CoordinatorId)
                    .HasName("FK_scholarship_program_tracking_agent");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_scholarship_program_tracking_user");

                entity.HasIndex(e => e.ScholarshipProgramUniversityId)
                    .HasName("FK_scholarship_program_tracking_scholarship_program_university");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_tracking_status");

                entity.HasIndex(e => e.TechnicalId)
                    .HasName("FK_scholarship_program_tracking_agent_2");

                entity.HasIndex(e => e.UniversityId)
                    .HasName("FK_scholarship_program_tracing_university");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_scholarship_program_tracking_user_2");

                entity.Property(e => e.ScholarshipProgramTracingId).HasColumnName("scholarship_program_tracing_id");

                entity.Property(e => e.CoordinatorId).HasColumnName("coordinator_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ScholarshipProgramUniversityId).HasColumnName("scholarship_program_university_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TechnicalId).HasColumnName("technical_id");

                entity.Property(e => e.UniversityId).HasColumnName("university_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.Coordinator)
                    .WithMany(p => p.ScholarshipProgramTracingCoordinator)
                    .HasForeignKey(d => d.CoordinatorId)
                    .HasConstraintName("FK_scholarship_program_tracking_agent");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.ScholarshipProgramTracingCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_scholarship_program_tracking_user");

                entity.HasOne(d => d.ScholarshipProgramUniversity)
                    .WithMany(p => p.ScholarshipProgramTracing)
                    .HasForeignKey(d => d.ScholarshipProgramUniversityId)
                    .HasConstraintName("FK_scholarship_program_tracking_scholarship_program_university");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracing)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_tracking_status");

                entity.HasOne(d => d.Technical)
                    .WithMany(p => p.ScholarshipProgramTracingTechnical)
                    .HasForeignKey(d => d.TechnicalId)
                    .HasConstraintName("FK_scholarship_program_tracking_agent_2");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.ScholarshipProgramTracing)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK_scholarship_program_tracing_university");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.ScholarshipProgramTracingUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_scholarship_program_tracking_user_2");
            });

            modelBuilder.Entity<ScholarshipProgramTracingAgreement>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_agreement");

                entity.HasIndex(e => e.CommentedUserId)
                    .HasName("FK_scholarship_program_tracking_agreement_user_3");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_scholarship_program_tracking_agreement_user");

                entity.HasIndex(e => e.ScholarshipProgramTracingId)
                    .HasName("FK_tracking");

                entity.HasIndex(e => e.ScholarshipProgramUniversityAgreementId)
                    .HasName("FK_scholarship_program_tracing_agreement");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_tracking_agreement_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_scholarship_program_tracking_agreement_user_2");

                entity.Property(e => e.ScholarshipProgramTracingAgreementId).HasColumnName("scholarship_program_tracing_agreement_id");

                entity.Property(e => e.CommentedUserId).HasColumnName("commented_user_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.ScholarshipProgramTracingAgreementDescription)
                    .HasColumnName("scholarship_program_tracing_agreement_description")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ScholarshipProgramTracingAgreementDescription2)
                    .HasColumnName("scholarship_program_tracing_agreement_description2")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ScholarshipProgramTracingAgreementDescription3)
                    .HasColumnName("scholarship_program_tracing_agreement_description3")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ScholarshipProgramTracingId).HasColumnName("scholarship_program_tracing_id");

                entity.Property(e => e.ScholarshipProgramUniversityAgreementId).HasColumnName("scholarship_program_university_agreement_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.CommentedUser)
                    .WithMany(p => p.ScholarshipProgramTracingAgreementCommentedUser)
                    .HasForeignKey(d => d.CommentedUserId)
                    .HasConstraintName("FK_scholarship_program_tracking_agreement_user_3");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.ScholarshipProgramTracingAgreementCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_scholarship_program_tracking_agreement_user");

                entity.HasOne(d => d.ScholarshipProgramTracing)
                    .WithMany(p => p.ScholarshipProgramTracingAgreement)
                    .HasForeignKey(d => d.ScholarshipProgramTracingId)
                    .HasConstraintName("FK_tracking");

                entity.HasOne(d => d.ScholarshipProgramUniversityAgreement)
                    .WithMany(p => p.ScholarshipProgramTracingAgreement)
                    .HasForeignKey(d => d.ScholarshipProgramUniversityAgreementId)
                    .HasConstraintName("FK_scholarship_program_tracing_agreement");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingAgreement)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_tracking_agreement_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.ScholarshipProgramTracingAgreementUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_scholarship_program_tracking_agreement_user_2");
            });

            modelBuilder.Entity<ScholarshipProgramTracingAgreementFile>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_agreement_file");

                entity.HasIndex(e => e.FileId)
                    .HasName("FK_scholarship_program_tracking_agreement_file_file");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_tracking_agreement_file_status");

                entity.Property(e => e.ScholarshipProgramTracingAgreementFileId).HasColumnName("scholarship_program_tracing_agreement_file_id");

                entity.Property(e => e.AgreementFileDescription)
                    .IsRequired()
                    .HasColumnName("agreement_file_description")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.ScholarshipProgramTracingAgreementId).HasColumnName("scholarship_program_tracing_agreement_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ScholarshipProgramTracingAgreementFile)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_scholarship_program_tracking_agreement_file_file");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingAgreementFile)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_tracking_agreement_file_status");
            });

            modelBuilder.Entity<ScholarshipProgramTracingCourse>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_course");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_tracing_plan_status");

                entity.HasIndex(e => e.TracingId)
                    .HasName("FK_scholarship_program_tracing_plan_scholarship_program_tracing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseEndDate)
                    .HasColumnName("course_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.CourseName)
                    .HasColumnName("course_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CourseStartDate)
                    .HasColumnName("course_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.HoursTaken).HasColumnName("hours_taken");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StudentsQuantity).HasColumnName("students_quantity");

                entity.Property(e => e.TracingId).HasColumnName("tracing_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingCourse)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_tracing_plan_status");

                entity.HasOne(d => d.Tracing)
                    .WithMany(p => p.ScholarshipProgramTracingCourse)
                    .HasForeignKey(d => d.TracingId)
                    .HasConstraintName("FK_scholarship_program_tracing_plan_scholarship_program_tracing");
            });

            modelBuilder.Entity<ScholarshipProgramTracingCourseFile>(entity =>
            {
                entity.HasKey(e => e.CourseFileId)
                    .HasName("PRIMARY");

                entity.ToTable("scholarship_program_tracing_course_file");

                entity.HasIndex(e => e.FileId)
                    .HasName("FK__tracing_plan_file");

                entity.HasIndex(e => e.FileTypeId)
                    .HasName("FK_file_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_tracing_plan_status");

                entity.HasIndex(e => e.TracingId)
                    .HasName("FK__tracing_plan");

                entity.Property(e => e.CourseFileId).HasColumnName("course_file_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.FileTypeId).HasColumnName("file_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TracingId).HasColumnName("tracing_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ScholarshipProgramTracingCourseFile)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK__tracing_plan_file");

                entity.HasOne(d => d.FileType)
                    .WithMany(p => p.ScholarshipProgramTracingCourseFile)
                    .HasForeignKey(d => d.FileTypeId)
                    .HasConstraintName("FK_file_type");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingCourseFile)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_tracing_plan_status");

                entity.HasOne(d => d.Tracing)
                    .WithMany(p => p.ScholarshipProgramTracingCourseFile)
                    .HasForeignKey(d => d.TracingId)
                    .HasConstraintName("FK__tracing_plan");
            });

            modelBuilder.Entity<ScholarshipProgramTracingCourseFileType>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_course_file_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.FileTypeName)
                    .HasColumnName("file_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");
            });

            modelBuilder.Entity<ScholarshipProgramTracingPractice>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_practice");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_practice_status");

                entity.HasIndex(e => e.TracingId)
                    .HasName("FK_practice_tracing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .HasColumnName("activity")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Coordinator)
                    .HasColumnName("coordinator")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Periodicity)
                    .HasColumnName("periodicity")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Superviser)
                    .HasColumnName("superviser")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Teacher)
                    .HasColumnName("teacher")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TracingId).HasColumnName("tracing_id");

                entity.Property(e => e.UpgradeDate)
                    .HasColumnName("upgrade_date")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingPractice)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_practice_status");

                entity.HasOne(d => d.Tracing)
                    .WithMany(p => p.ScholarshipProgramTracingPractice)
                    .HasForeignKey(d => d.TracingId)
                    .HasConstraintName("FK_practice_tracing");
            });

            modelBuilder.Entity<ScholarshipProgramTracingPracticePlanning>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_practice_planning");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_planning_status");

                entity.HasIndex(e => e.TracingId)
                    .HasName("FK_planning_tracing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.Finished)
                    .HasColumnName("finished")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Started)
                    .HasColumnName("started")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TracingId).HasColumnName("tracing_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingPracticePlanning)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_planning_status");

                entity.HasOne(d => d.Tracing)
                    .WithMany(p => p.ScholarshipProgramTracingPracticePlanning)
                    .HasForeignKey(d => d.TracingId)
                    .HasConstraintName("FK_planning_tracing");
            });

            modelBuilder.Entity<ScholarshipProgramTracingQualitySystem>(entity =>
            {
                entity.HasKey(e => e.QualityFileId)
                    .HasName("PRIMARY");

                entity.ToTable("scholarship_program_tracing_quality_system");

                entity.HasIndex(e => e.FileId)
                    .HasName("FK_file_quality");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_status_quality");

                entity.HasIndex(e => e.TracingId)
                    .HasName("FK_program_tracing");

                entity.Property(e => e.QualityFileId).HasColumnName("quality_file_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.FileTypeId).HasColumnName("file_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TracingId).HasColumnName("tracing_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ScholarshipProgramTracingQualitySystem)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_file_quality");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingQualitySystem)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_status_quality");

                entity.HasOne(d => d.Tracing)
                    .WithMany(p => p.ScholarshipProgramTracingQualitySystem)
                    .HasForeignKey(d => d.TracingId)
                    .HasConstraintName("FK_program_tracing");
            });

            modelBuilder.Entity<ScholarshipProgramTracingQualitySystemFileType>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_quality_system_file_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.FileTypeName)
                    .HasColumnName("file_type_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");
            });

            modelBuilder.Entity<ScholarshipProgramTracingStudentPractice>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_student_practice");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_tracing_student_practice_status");

                entity.HasIndex(e => e.TracingId)
                    .HasName("FK_student_practice_tracing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.PracticeCenterQuantity).HasColumnName("practice_center_quantity");

                entity.Property(e => e.PracticeType)
                    .HasColumnName("practice_type")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StudentsQuantity).HasColumnName("students_quantity");

                entity.Property(e => e.SupervisorQuantity).HasColumnName("supervisor_quantity");

                entity.Property(e => e.TeacherQuantity).HasColumnName("teacher_quantity");

                entity.Property(e => e.TracingId).HasColumnName("tracing_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingStudentPractice)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_tracing_student_practice_status");

                entity.HasOne(d => d.Tracing)
                    .WithMany(p => p.ScholarshipProgramTracingStudentPractice)
                    .HasForeignKey(d => d.TracingId)
                    .HasConstraintName("FK_student_practice_tracing");
            });

            modelBuilder.Entity<ScholarshipProgramTracingStudentSupport>(entity =>
            {
                entity.ToTable("scholarship_program_tracing_student_support");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_tracing_student_support_status");

                entity.HasIndex(e => e.TracingId)
                    .HasName("FK_student_support_tracing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.IndicatorId).HasColumnName("indicator_id");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TracingId).HasColumnName("tracing_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramTracingStudentSupport)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_tracing_student_support_status");

                entity.HasOne(d => d.Tracing)
                    .WithMany(p => p.ScholarshipProgramTracingStudentSupport)
                    .HasForeignKey(d => d.TracingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_student_support_tracing");
            });

            modelBuilder.Entity<ScholarshipProgramUniversity>(entity =>
            {
                entity.ToTable("scholarship_program_university");

                entity.HasIndex(e => e.CoordinatorId)
                    .HasName("FK_scholarship_program_university_agent");

                entity.HasIndex(e => e.ScholarshipLevelId)
                    .HasName("FK_scholarship_program_university_scholarship_level");

                entity.HasIndex(e => e.ScholarshipProgramId)
                    .HasName("FK_scholarship_program_university_scholarship_program");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_university_status");

                entity.HasIndex(e => e.TechnicalId)
                    .HasName("FK_scholarship_program_university_agent_2");

                entity.HasIndex(e => e.UniversityId)
                    .HasName("FK_scholarship_program_university_university");

                entity.Property(e => e.ScholarshipProgramUniversityId).HasColumnName("scholarship_program_university_id");

                entity.Property(e => e.ActiveStudents).HasColumnName("active_students");

                entity.Property(e => e.AnnouncementEndDate)
                    .HasColumnName("announcement_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.AnnouncementStartDate)
                    .HasColumnName("announcement_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.ContractNumber)
                    .HasColumnName("contract_number")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CoordinatorId).HasColumnName("coordinator_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.ScatProgramCode)
                    .HasColumnName("scat_program_code")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ScatProgramId).HasColumnName("scat_program_id");

                entity.Property(e => e.ScholarshipLevelId).HasColumnName("scholarship_level_id");

                entity.Property(e => e.ScholarshipProgramId).HasColumnName("scholarship_program_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TechnicalId).HasColumnName("technical_id");

                entity.Property(e => e.UniversityId).HasColumnName("university_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Coordinator)
                    .WithMany(p => p.ScholarshipProgramUniversityCoordinator)
                    .HasForeignKey(d => d.CoordinatorId)
                    .HasConstraintName("FK_scholarship_program_university_agent");

                entity.HasOne(d => d.ScholarshipLevel)
                    .WithMany(p => p.ScholarshipProgramUniversity)
                    .HasForeignKey(d => d.ScholarshipLevelId)
                    .HasConstraintName("FK_scholarship_program_university_scholarship_level");

                entity.HasOne(d => d.ScholarshipProgram)
                    .WithMany(p => p.ScholarshipProgramUniversity)
                    .HasForeignKey(d => d.ScholarshipProgramId)
                    .HasConstraintName("FK_scholarship_program_university_scholarship_program");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramUniversity)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_university_status");

                entity.HasOne(d => d.Technical)
                    .WithMany(p => p.ScholarshipProgramUniversityTechnical)
                    .HasForeignKey(d => d.TechnicalId)
                    .HasConstraintName("FK_scholarship_program_university_agent_2");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.ScholarshipProgramUniversity)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK_scholarship_program_university_university");
            });

            modelBuilder.Entity<ScholarshipProgramUniversityAgent>(entity =>
            {
                entity.HasKey(e => e.ScholarshipProgramUniversityCordinatorId)
                    .HasName("PRIMARY");

                entity.ToTable("scholarship_program_university_agent");

                entity.HasIndex(e => e.AgentId)
                    .HasName("FK_scholarship_contact");

                entity.HasIndex(e => e.ScholarshipProgramUniversityId)
                    .HasName("FK_program_university");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_status");

                entity.Property(e => e.ScholarshipProgramUniversityCordinatorId).HasColumnName("scholarship_program_university_cordinator_id");

                entity.Property(e => e.AgentId).HasColumnName("agent_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.ScholarshipProgramUniversityId).HasColumnName("scholarship_program_university_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.ScholarshipProgramUniversityAgent)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_scholarship_contact");

                entity.HasOne(d => d.ScholarshipProgramUniversity)
                    .WithMany(p => p.ScholarshipProgramUniversityAgent)
                    .HasForeignKey(d => d.ScholarshipProgramUniversityId)
                    .HasConstraintName("FK_program_university");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramUniversityAgent)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_status");
            });

            modelBuilder.Entity<ScholarshipProgramUniversityAgreement>(entity =>
            {
                entity.ToTable("scholarship_program_university_agreement");

                entity.HasIndex(e => e.AgreementTypeId)
                    .HasName("FK_scholarship_program_university_agreement_agreement_type");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_scholarship_program_university_agreement_user");

                entity.HasIndex(e => e.ScholarshipProgramUniversityId)
                    .HasName("FK_scholarship_program_university");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_university_agreement_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_scholarship_program_university_agreement_user_2");

                entity.Property(e => e.ScholarshipProgramUniversityAgreementId).HasColumnName("scholarship_program_university_agreement_id");

                entity.Property(e => e.AgreementTypeId).HasColumnName("agreement_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.ScholarshipProgramUniversityAgreement1)
                    .HasColumnName("scholarship_program_university_agreement")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ScholarshipProgramUniversityId).HasColumnName("scholarship_program_university_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.AgreementType)
                    .WithMany(p => p.ScholarshipProgramUniversityAgreement)
                    .HasForeignKey(d => d.AgreementTypeId)
                    .HasConstraintName("FK_scholarship_program_university_agreement_agreement_type");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.ScholarshipProgramUniversityAgreementCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_scholarship_program_university_agreement_user");

                entity.HasOne(d => d.ScholarshipProgramUniversity)
                    .WithMany(p => p.ScholarshipProgramUniversityAgreement)
                    .HasForeignKey(d => d.ScholarshipProgramUniversityId)
                    .HasConstraintName("FK_scholarship_program_university");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramUniversityAgreement)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_university_agreement_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.ScholarshipProgramUniversityAgreementUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_scholarship_program_university_agreement_user_2");
            });

            modelBuilder.Entity<ScholarshipProgramUniversitySubjectMatter>(entity =>
            {
                entity.ToTable("scholarship_program_university_subject_matter");

                entity.HasIndex(e => e.PredictedTeacherId)
                    .HasName("FK_scholarship_program_university_subject_matter_teacher_2");

                entity.HasIndex(e => e.ScholarshipProgramUniversityId)
                    .HasName("FK_spusm_scholarship_program_university");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_scholarship_program_university_subject_matter_status");

                entity.HasIndex(e => e.SubjectMatterId)
                    .HasName("FK_scholarship_program_university_subject_matter_subject_matter");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("FK_scholarship_program_university_subject_matter_teacher");

                entity.Property(e => e.ScholarshipProgramUniversitySubjectMatterId).HasColumnName("scholarship_program_university_subject_matter_id");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.PredictedTeacherId).HasColumnName("predicted_teacher_id");

                entity.Property(e => e.ScholarshipProgramUniversityId).HasColumnName("scholarship_program_university_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.SubjectMatterCredits).HasColumnName("subject_matter_credits");

                entity.Property(e => e.SubjectMatterId).HasColumnName("subject_matter_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.PredictedTeacher)
                    .WithMany(p => p.ScholarshipProgramUniversitySubjectMatterPredictedTeacher)
                    .HasForeignKey(d => d.PredictedTeacherId)
                    .HasConstraintName("FK_scholarship_program_university_subject_matter_teacher_2");

                entity.HasOne(d => d.ScholarshipProgramUniversity)
                    .WithMany(p => p.ScholarshipProgramUniversitySubjectMatter)
                    .HasForeignKey(d => d.ScholarshipProgramUniversityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_spusm_scholarship_program_university");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScholarshipProgramUniversitySubjectMatter)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_scholarship_program_university_subject_matter_status");

                entity.HasOne(d => d.SubjectMatter)
                    .WithMany(p => p.ScholarshipProgramUniversitySubjectMatter)
                    .HasForeignKey(d => d.SubjectMatterId)
                    .HasConstraintName("FK_scholarship_program_university_subject_matter_subject_matter");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.ScholarshipProgramUniversitySubjectMatterTeacher)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_scholarship_program_university_subject_matter_teacher");
            });

            modelBuilder.Entity<ScholarshipProgramUniversityTeacherHiring>(entity =>
            {
                entity.ToTable("scholarship_program_university_teacher_hiring");

                entity.Property(e => e.ScholarshipProgramUniversityTeacherHiringId).HasColumnName("scholarship_program_university_teacher_hiring_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TeacherHiringTypeId).HasColumnName("teacher_hiring_type_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");
            });

            modelBuilder.Entity<SpuTaughtSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spu_taught_subject");

                entity.Property(e => e.Columna3).HasColumnName("Columna 3");

                entity.Property(e => e.SpuTaughtSubjectId).HasColumnName("spu_taught_subject_id");

                entity.Property(e => e.SubjectMatterId).HasColumnName("subject_matter_id");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusName)
                    .HasColumnName("status_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudyPlanManagement>(entity =>
            {
                entity.ToTable("study_plan_management");

                entity.Property(e => e.StudyPlanManagementId).HasColumnName("study_plan_management_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.ScholarshipProgramUniversityId).HasColumnName("scholarship_program_university_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StudyPlanManagementName)
                    .HasColumnName("study_plan_management_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");
            });

            modelBuilder.Entity<SubjectMatter>(entity =>
            {
                entity.ToTable("subject_matter");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_subject_matter_user");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_subject_matter_status");

                entity.HasIndex(e => e.SubjectMatterCode)
                    .HasName("subject_matter_code")
                    .IsUnique();

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_subject_matter_user_2");

                entity.Property(e => e.SubjectMatterId).HasColumnName("subject_matter_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.SubjectMatterCode)
                    .IsRequired()
                    .HasColumnName("subject_matter_code")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SubjectMatterName)
                    .HasColumnName("subject_matter_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.SubjectMatterCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_subject_matter_user");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.SubjectMatter)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_subject_matter_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.SubjectMatterUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_subject_matter_user_2");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("teacher");

                entity.HasIndex(e => e.ContactId)
                    .HasName("FK_teacher_contact");

                entity.HasIndex(e => e.HigherTeacherEducationId)
                    .HasName("FK_teacher_teacher_education");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_teacher_status");

                entity.HasIndex(e => e.TeacherHiringTypeId)
                    .HasName("FK_teacher_teacher_hiring_type");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.HigherTeacherEducationId).HasColumnName("higher_teacher_education_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TeacherCategory)
                    .HasColumnName("teacher_category")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherHasAdminFunctions)
                    .HasColumnName("teacher_has_admin_functions")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TeacherHiringTypeId).HasColumnName("teacher_hiring_type_id");

                entity.Property(e => e.TeacherIsPac)
                    .HasColumnName("teacher_is_pac")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TeacherJobStartDate)
                    .HasColumnName("teacher_job_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeacherMatchHigherTitle)
                    .HasColumnName("teacher_match_higher_title")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TeacherResearchProcess).HasColumnName("teacher_research_process");

                entity.Property(e => e.TeacherResearchPublished).HasColumnName("teacher_research_published");

                entity.Property(e => e.TeacherWorkForOtherInstitutions)
                    .HasColumnName("teacher_work_for_other_institutions")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_teacher_contact");

                entity.HasOne(d => d.HigherTeacherEducation)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.HigherTeacherEducationId)
                    .HasConstraintName("FK_teacher_teacher_education");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_teacher_status");

                entity.HasOne(d => d.TeacherHiringType)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.TeacherHiringTypeId)
                    .HasConstraintName("FK_teacher_teacher_hiring_type");
            });

            modelBuilder.Entity<TeacherEducation>(entity =>
            {
                entity.ToTable("teacher_education");

                entity.HasIndex(e => e.EducationTypeId)
                    .HasName("FK_teacher_education_education_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_teacher_education_status");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("FK_teacher_education_teacher");

                entity.Property(e => e.TeacherEducationId).HasColumnName("teacher_education_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.EducationTypeId).HasColumnName("education_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TeacherEducationFinishDate)
                    .HasColumnName("teacher_education_finish_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeacherEducationInstitution)
                    .HasColumnName("teacher_education_institution")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherEducationTitle)
                    .HasColumnName("teacher_education_title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.EducationType)
                    .WithMany(p => p.TeacherEducation)
                    .HasForeignKey(d => d.EducationTypeId)
                    .HasConstraintName("FK_teacher_education_education_type");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TeacherEducation)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_teacher_education_status");

                entity.HasOne(d => d.TeacherNavigation)
                    .WithMany(p => p.TeacherEducation)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_teacher_education_teacher");
            });

            modelBuilder.Entity<TeacherFile>(entity =>
            {
                entity.ToTable("teacher_file");

                entity.HasIndex(e => e.FileId)
                    .HasName("FK_teacher_file_file");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_teacher_file_status");

                entity.HasIndex(e => e.TeacherFileTypeId)
                    .HasName("FK_teacher_file_teacher_file_type");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("FK_teacher_file_teacher");

                entity.HasIndex(e => e.TeacherResearchId)
                    .HasName("FK_teacher_file_teacher_research");

                entity.Property(e => e.TeacherFileId).HasColumnName("teacher_file_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TeacherFileComment)
                    .HasColumnName("teacher_file_comment")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherFileTypeId).HasColumnName("teacher_file_type_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.TeacherResearchId).HasColumnName("teacher_research_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.TeacherFile)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_teacher_file_file");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TeacherFile)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_teacher_file_status");

                entity.HasOne(d => d.TeacherFileType)
                    .WithMany(p => p.TeacherFile)
                    .HasForeignKey(d => d.TeacherFileTypeId)
                    .HasConstraintName("FK_teacher_file_teacher_file_type");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherFile)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_teacher_file_teacher");

                entity.HasOne(d => d.TeacherResearch)
                    .WithMany(p => p.TeacherFile)
                    .HasForeignKey(d => d.TeacherResearchId)
                    .HasConstraintName("FK_teacher_file_teacher_research");
            });

            modelBuilder.Entity<TeacherFileType>(entity =>
            {
                entity.ToTable("teacher_file_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_teacher_file_type_status");

                entity.Property(e => e.TeacherFileTypeId).HasColumnName("teacher_file_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TeacherFileTypeName)
                    .HasColumnName("teacher_file_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TeacherFileType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_teacher_file_type_status");
            });

            modelBuilder.Entity<TeacherHiringType>(entity =>
            {
                entity.ToTable("teacher_hiring_type");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_teacher_hiring_type_status");

                entity.Property(e => e.TeacherHiringTypeId).HasColumnName("teacher_hiring_type_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TeacherHiringTypeName)
                    .HasColumnName("teacher_hiring_type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TeacherHiringType)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_teacher_hiring_type_status");
            });

            modelBuilder.Entity<TeacherResearch>(entity =>
            {
                entity.ToTable("teacher_research");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_teacher_research_status");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("FK_teacher_research_teacher");

                entity.Property(e => e.TeacherResearchId).HasColumnName("teacher_research_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.TeacherResearchName)
                    .HasColumnName("teacher_research_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherResearchQuantity).HasColumnName("teacher_research_quantity");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TeacherResearch)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_teacher_research_status");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherResearch)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_teacher_research_teacher");
            });

            modelBuilder.Entity<TracingStudyPlanDevelopment>(entity =>
            {
                entity.ToTable("tracing_study_plan_development");

                entity.HasIndex(e => e.AssignedTeacherId)
                    .HasName("FK_teacher_teacher_2");

                entity.HasIndex(e => e.HigherTitleSupportMatterId)
                    .HasName("FK_teacher_education");

                entity.HasIndex(e => e.ScholarshipProgramTracingId)
                    .HasName("FK_tracing");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_teacher_status_status");

                entity.HasIndex(e => e.SubjectMatterId)
                    .HasName("FK_teacher_subject_matter");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("FK_teacher_teacher");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovedStudentsQuantity).HasColumnName("approved_students_quantity");

                entity.Property(e => e.AssignedTeacherId).HasColumnName("assigned_teacher_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.DesertedStudentsQuantity).HasColumnName("deserted_students_quantity");

                entity.Property(e => e.HigherTitleMatchAssignedMatter)
                    .HasColumnName("higher_title_match_assigned_matter")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.HigherTitleSupportMatterId).HasColumnName("higher_title_support_matter_id");

                entity.Property(e => e.ReprovedStudentsQuantity).HasColumnName("reproved_students_quantity");

                entity.Property(e => e.ScholarshipProgramTracingId).HasColumnName("scholarship_program_tracing_id");

                entity.Property(e => e.ScoreAverageStudents).HasColumnName("score_average_students");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.SubjectMatterId).HasColumnName("subject_matter_id");

                entity.Property(e => e.SubjectMatterScoreReportFileId).HasColumnName("subject_matter_score_report_file_id");

                entity.Property(e => e.SubjectMatterTimeEnd).HasColumnName("subject_matter_time_end");

                entity.Property(e => e.SubjectMatterTimeStart).HasColumnName("subject_matter_time_start");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.HasOne(d => d.AssignedTeacher)
                    .WithMany(p => p.TracingStudyPlanDevelopmentAssignedTeacher)
                    .HasForeignKey(d => d.AssignedTeacherId)
                    .HasConstraintName("FK_teacher_teacher_2");

                entity.HasOne(d => d.HigherTitleSupportMatter)
                    .WithMany(p => p.TracingStudyPlanDevelopment)
                    .HasForeignKey(d => d.HigherTitleSupportMatterId)
                    .HasConstraintName("FK_teacher_education");

                entity.HasOne(d => d.ScholarshipProgramTracing)
                    .WithMany(p => p.TracingStudyPlanDevelopment)
                    .HasForeignKey(d => d.ScholarshipProgramTracingId)
                    .HasConstraintName("FK_tracing");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TracingStudyPlanDevelopment)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_teacher_status_status");

                entity.HasOne(d => d.SubjectMatter)
                    .WithMany(p => p.TracingStudyPlanDevelopment)
                    .HasForeignKey(d => d.SubjectMatterId)
                    .HasConstraintName("FK_teacher_subject_matter");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TracingStudyPlanDevelopmentTeacher)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_teacher_teacher");
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.ToTable("university");

                entity.HasIndex(e => e.AddressId)
                    .HasName("FK_university_address");

                entity.HasIndex(e => e.CommunicationId)
                    .HasName("FK_university_communication");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_university_status");

                entity.Property(e => e.UniversityId).HasColumnName("university_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CommunicationId).HasColumnName("communication_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UniversityAcronym)
                    .HasColumnName("university_acronym")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityCampus)
                    .HasColumnName("university_campus")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UniversityName)
                    .HasColumnName("university_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.University)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_university_address");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.University)
                    .HasForeignKey(d => d.CommunicationId)
                    .HasConstraintName("FK_university_communication");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.University)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_university_status");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("FK_user_company");

                entity.HasIndex(e => e.ContactId)
                    .HasName("FK_user_contact");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_user_user");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("FK_user_office");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_user_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_user_user_2");

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("FK_user_user_role");

                entity.HasIndex(e => e.UserScheduleId)
                    .HasName("FK_user_schedule");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.Property(e => e.UserDateExpirePassword).HasColumnName("user_date_expire_password");

                entity.Property(e => e.UserExpirePassword)
                    .HasColumnName("user_expire_password")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.UserLogin)
                    .HasColumnName("user_login")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("user_password")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("user_role_id");

                entity.Property(e => e.UserScheduleId).HasColumnName("user_schedule_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_user_company");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_user_contact");

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.InverseCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_user_user");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_user_office");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_user_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.InverseUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_user_user_2");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_user_user_role");

                entity.HasOne(d => d.UserSchedule)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserScheduleId)
                    .HasConstraintName("FK_user_schedule");
            });

            modelBuilder.Entity<UserMapRole>(entity =>
            {
                entity.ToTable("user_map_role");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_user_roles_user");

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("FK_user_roles_user_role");

                entity.Property(e => e.UserMapRoleId).HasColumnName("user_map_role_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserRoleId).HasColumnName("user_role_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMapRole)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_user_roles_user");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserMapRole)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_user_roles_user_role");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("user_role");

                entity.HasIndex(e => e.CreationUserId)
                    .HasName("FK_user_role_user");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("FK_user_role_office");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK_user_role_status");

                entity.HasIndex(e => e.UpgradeUserId)
                    .HasName("FK_user_role_user_2");

                entity.Property(e => e.UserRoleId).HasColumnName("user_role_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.CreationUserId).HasColumnName("creation_user_id");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UpgradeUserId).HasColumnName("upgrade_user_id");

                entity.Property(e => e.UserRoleDescription)
                    .HasColumnName("user_role_description")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleName)
                    .HasColumnName("user_role_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreationUser)
                    .WithMany(p => p.UserRoleCreationUser)
                    .HasForeignKey(d => d.CreationUserId)
                    .HasConstraintName("FK_user_role_user");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_role_office");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_user_role_status");

                entity.HasOne(d => d.UpgradeUser)
                    .WithMany(p => p.UserRoleUpgradeUser)
                    .HasForeignKey(d => d.UpgradeUserId)
                    .HasConstraintName("FK_user_role_user_2");
            });

            modelBuilder.Entity<UserRolePermission>(entity =>
            {
                entity.ToTable("user_role_permission");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("FK_user_role_permission_table");

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("FK_user_role_permission_user_role");

                entity.Property(e => e.UserRolePermissionId).HasColumnName("user_role_permission_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.UserRoleId).HasColumnName("user_role_id");

                entity.Property(e => e.UserRolePermissionName)
                    .HasColumnName("user_role_permission_name")
                    .HasColumnType("enum('INSERT','UPDATE','DELETE','QUERY','ALL')");

                entity.Property(e => e.UserRolePermissionValue)
                    .HasColumnName("user_role_permission_value")
                    .HasColumnType("enum('GRANTED','DENIED','GRANTED INDIRECTLY')");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.UserRolePermission)
                    .HasForeignKey(d => d.ObjectId)
                    .HasConstraintName("FK_user_role_permission_table");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserRolePermission)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_user_role_permission_user_role");
            });

            modelBuilder.Entity<UserUniversity>(entity =>
            {
                entity.ToTable("user_university");

                entity.HasIndex(e => e.StatusId)
                    .HasName("FK__status");

                entity.HasIndex(e => e.UniversityId)
                    .HasName("FK__university");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK__user");

                entity.Property(e => e.UserUniversityId).HasColumnName("user_university_id");

                entity.Property(e => e.CreationDate).HasColumnName("creation_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UniversityId).HasColumnName("university_id");

                entity.Property(e => e.UpgradeDate).HasColumnName("upgrade_date");

                entity.Property(e => e.UserCreationId).HasColumnName("user_creation_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserUpgradeId).HasColumnName("user_upgrade_id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UserUniversity)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__status");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.UserUniversity)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK__university");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserUniversity)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__user");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint unsigned");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailVerifiedAt).HasColumnName("email_verified_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
