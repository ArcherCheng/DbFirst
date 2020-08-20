using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodPos.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppKeyCode> AppKeyCode { get; set; }
        public virtual DbSet<AppKeySystem> AppKeySystem { get; set; }
        public virtual DbSet<AppLogTable> AppLogTable { get; set; }
        public virtual DbSet<AppLogUser> AppLogUser { get; set; }
        public virtual DbSet<AppSysController> AppSysController { get; set; }
        public virtual DbSet<AppSysRole> AppSysRole { get; set; }
        public virtual DbSet<AppSysRoleController> AppSysRoleController { get; set; }
        public virtual DbSet<AppSysUser> AppSysUser { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodOff> FoodOff { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderDetailAddOn> OrderDetailAddOn { get; set; }
        public virtual DbSet<OrderMaster> OrderMaster { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswer { get; set; }
        public virtual DbSet<QuestionDiscount> QuestionDiscount { get; set; }
        public virtual DbSet<Questionnaire> Questionnaire { get; set; }
        public virtual DbSet<QuestionnaireAnswer> QuestionnaireAnswer { get; set; }
        public virtual DbSet<TypeAddOn> TypeAddOn { get; set; }
        public virtual DbSet<ViewAppKeyCodeGroup> ViewAppKeyCodeGroup { get; set; }
        public virtual DbSet<ViewAppKeySystemGroup> ViewAppKeySystemGroup { get; set; }
        public virtual DbSet<ViewCustomerDiscount> ViewCustomerDiscount { get; set; }
        public virtual DbSet<ViewCustomerOrderSum> ViewCustomerOrderSum { get; set; }
        public virtual DbSet<ViewCustomerOrderSum30D> ViewCustomerOrderSum30D { get; set; }
        public virtual DbSet<ViewCustomerOrderSumAll> ViewCustomerOrderSumAll { get; set; }
        public virtual DbSet<ViewFoodOffMaxOffDate> ViewFoodOffMaxOffDate { get; set; }
        public virtual DbSet<ViewInvoiceDaySum> ViewInvoiceDaySum { get; set; }
        public virtual DbSet<ViewInvoiceMonthSum> ViewInvoiceMonthSum { get; set; }
        public virtual DbSet<ViewOrderDetailFoodDaySum> ViewOrderDetailFoodDaySum { get; set; }
        public virtual DbSet<ViewOrderDetailFoodMonthSum> ViewOrderDetailFoodMonthSum { get; set; }
        public virtual DbSet<ViewOrderDetailFoodWeekDaySum> ViewOrderDetailFoodWeekDaySum { get; set; }
        public virtual DbSet<ViewOrderDetailFoodWeekSum> ViewOrderDetailFoodWeekSum { get; set; }
        public virtual DbSet<ViewOrderTypeDaySum> ViewOrderTypeDaySum { get; set; }
        public virtual DbSet<ViewOrderTypeMonthSum> ViewOrderTypeMonthSum { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswer1M> ViewQuestionnaireAnswer1M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswer1W> ViewQuestionnaireAnswer1W { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswer1Y> ViewQuestionnaireAnswer1Y { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswer2Y> ViewQuestionnaireAnswer2Y { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswer3M> ViewQuestionnaireAnswer3M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswer6M> ViewQuestionnaireAnswer6M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerAll> ViewQuestionnaireAnswerAll { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount1M> ViewQuestionnaireAnswerCount1M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount1W> ViewQuestionnaireAnswerCount1W { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount1Y> ViewQuestionnaireAnswerCount1Y { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount2Y> ViewQuestionnaireAnswerCount2Y { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount3M> ViewQuestionnaireAnswerCount3M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount6M> ViewQuestionnaireAnswerCount6M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCountAll> ViewQuestionnaireAnswerCountAll { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=(local)\\SqlExpress;database=foodPos2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppKeyCode>(entity =>
            {
                entity.HasIndex(e => new { e.AppCodeGroup, e.AppCodeValue })
                    .HasName("AppKeyCode_Index1")
                    .IsUnique();

                entity.Property(e => e.AppCodeGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AppCodeLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AppCodeValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppKeySystem>(entity =>
            {
                entity.HasIndex(e => e.AppSysKey)
                    .HasName("AppKeySystem_Index1")
                    .IsUnique();

                entity.Property(e => e.AppSysGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AppSysKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AppSysLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AppSysValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppLogTable>(entity =>
            {
                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AppLogUser>(entity =>
            {
                entity.Property(e => e.Destination).HasMaxLength(250);

                entity.Property(e => e.Method).HasMaxLength(250);

                entity.Property(e => e.QueryString).HasMaxLength(250);

                entity.Property(e => e.Refer).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppSysController>(entity =>
            {
                entity.HasKey(e => e.ControllerId)
                    .HasName("AppSysController_Key");

                entity.HasIndex(e => e.ControllerName)
                    .HasName("AppSysController_Index1")
                    .IsUnique();

                entity.Property(e => e.Actions).HasMaxLength(250);

                entity.Property(e => e.AppSystem).HasMaxLength(50);

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descriptions).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppSysRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("AppSysRole_Key");

                entity.HasIndex(e => e.RoleName)
                    .HasName("AppSysRole_Index1")
                    .IsUnique();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppSysRoleController>(entity =>
            {
                entity.HasIndex(e => new { e.RoleId, e.ControllerId })
                    .HasName("AppSysRoleController_Index1")
                    .IsUnique();

                entity.Property(e => e.DenyActions).HasMaxLength(250);

                entity.Property(e => e.PermitActions).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Controller)
                    .WithMany(p => p.AppSysRoleController)
                    .HasForeignKey(d => d.ControllerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppSysRoleController_AppSysController");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppSysRoleController)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppSysRoleController_AppSysRole");
            });

            modelBuilder.Entity<AppSysUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("AppSysUser_Key");

                entity.HasIndex(e => e.Email)
                    .HasName("AppSysUser_Index1")
                    .IsUnique();

                entity.HasIndex(e => e.Phone)
                    .HasName("AppSysUser_Index2")
                    .IsUnique();

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsOnOff).HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.MainPhotoUrl).HasMaxLength(250);

                entity.Property(e => e.PasswordHash).HasMaxLength(2000);

                entity.Property(e => e.PasswordSalt).HasMaxLength(2000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserData).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppSysUser)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("AppSysUser_AppSysRole");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.CustomerName)
                    .HasName("Customer_Index1")
                    .IsUnique();

                entity.HasIndex(e => e.MobileNo)
                    .HasName("Customer_Index2");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Contactor).HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PostNo).HasMaxLength(10);

                entity.Property(e => e.TaxNo).HasMaxLength(50);

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasIndex(e => e.FoodName)
                    .HasName("Food_Index1")
                    .IsUnique();

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FoodType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PictureUrl1).HasMaxLength(100);

                entity.Property(e => e.PictureUrl2).HasMaxLength(100);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<FoodOff>(entity =>
            {
                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OffDate1).HasColumnType("date");

                entity.Property(e => e.OffDate2).HasColumnType("date");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.FoodOff)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FoodOff_Food");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasIndex(e => new { e.InvoiceNo1, e.InvoiceNo2 })
                    .HasName("Invoice_Index1");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo1)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.InvoiceYymm)
                    .IsRequired()
                    .HasColumnName("InvoiceYYMM")
                    .HasMaxLength(30);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.TaxNo).HasMaxLength(30);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("OrderDetail_Key");

                entity.Property(e => e.CookUser).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetail_Food");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetail_OrderMaster");
            });

            modelBuilder.Entity<OrderDetailAddOn>(entity =>
            {
                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.AddOn)
                    .WithMany(p => p.OrderDetailAddOn)
                    .HasForeignKey(d => d.AddOnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetailAddOn_TypeAddOn");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.OrderDetailAddOn)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetailAddOn_OrderDetail");
            });

            modelBuilder.Entity<OrderMaster>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("OrderMaster_Key");

                entity.Property(e => e.DutyNo).HasMaxLength(10);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasIndex(e => e.PromotionName)
                    .HasName("Promotion_Index1")
                    .IsUnique();

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PromotionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PromotionType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasIndex(e => e.QuestionDesc)
                    .HasName("Question_Index1")
                    .IsUnique();

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.QuestionDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<QuestionAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("QuestionAnswer_Key");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuestionAnswer_Question");
            });

            modelBuilder.Entity<QuestionDiscount>(entity =>
            {
                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity.HasIndex(e => e.DiscountGuid)
                    .HasName("Questionnaire_Index1")
                    .IsUnique()
                    .HasFilter("([DiscountGuid] IS NOT NULL)");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("Questionnaire_Index2")
                    .IsUnique()
                    .HasFilter("([InvoiceId] IS NOT NULL)");

                entity.Property(e => e.DiscountDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountGuid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Suggestion).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<QuestionnaireAnswer>(entity =>
            {
                entity.HasIndex(e => new { e.QuestionnaireId, e.QuestionId })
                    .HasName("QuestionnaireAnswer_Index1")
                    .IsUnique();

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.QuestionnaireAnswer)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuestionnaireAnswer_QuestionAnswer");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionnaireAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuestionnaireAnswer_Question");

                entity.HasOne(d => d.Questionnaire)
                    .WithMany(p => p.QuestionnaireAnswer)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuestionnaireAnswer_Questionnaire");
            });

            modelBuilder.Entity<TypeAddOn>(entity =>
            {
                entity.HasKey(e => e.AddOnId)
                    .HasName("TypeAddOn_Key");

                entity.HasIndex(e => new { e.AddOnType, e.AddOnName })
                    .HasName("TypeAddOn_Index1")
                    .IsUnique();

                entity.Property(e => e.AddOnName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AddOnType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewAppKeyCodeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAppKeyCodeGroup");

                entity.Property(e => e.AppCodeGroup)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewAppKeySystemGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAppKeySystemGroup");

                entity.Property(e => e.AppSysGroup)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewCustomerDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCustomerDiscount");

                entity.Property(e => e.DiscountDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountGuid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ViewCustomerOrderSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCustomerOrderSum");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.TaxNo).HasMaxLength(50);

                entity.Property(e => e.TelNo).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewCustomerOrderSum30D>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCustomerOrderSum30D");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");
            });

            modelBuilder.Entity<ViewCustomerOrderSumAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCustomerOrderSumAll");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");
            });

            modelBuilder.Entity<ViewFoodOffMaxOffDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewFoodOffMaxOffDate");

                entity.Property(e => e.OffDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewInvoiceDaySum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewInvoiceDaySum");

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewInvoiceMonthSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewInvoiceMonthSum");

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderDetailFoodDaySum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodDaySum");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderDetailFoodMonthSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodMonthSum");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.OrderMonth)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderDetailFoodWeekDaySum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodWeekDaySum");

                entity.Property(e => e.FoodName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodWeekSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodWeekSum");

                entity.Property(e => e.FoodName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderTypeDaySum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderTypeDaySum");

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderTypeMonthSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderTypeMonthSum");

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswer1M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswer1M");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answerDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswer1W>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswer1W");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answerDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswer1Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswer1Y");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answerDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswer2Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswer2Y");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answerDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswer3M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswer3M");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answerDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswer6M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswer6M");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answerDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerAll");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answerDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount1M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount1M");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount1W>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount1W");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount1Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount1Y");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount2Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount2Y");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount3M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount3M");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount6M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount6M");
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCountAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCountAll");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
