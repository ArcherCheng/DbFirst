using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodPos.Domain
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

        public virtual DbSet<AppLogRequest> AppLogRequest { get; set; }
        public virtual DbSet<AppLogTable> AppLogTable { get; set; }
        public virtual DbSet<AppSysPermission> AppSysPermission { get; set; }
        public virtual DbSet<AppSysRole> AppSysRole { get; set; }
        public virtual DbSet<AppSysRolePermission> AppSysRolePermission { get; set; }
        public virtual DbSet<AppSysRoleUser> AppSysRoleUser { get; set; }
        public virtual DbSet<AppSysUser> AppSysUser { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodOff> FoodOff { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<KeyCode> KeyCode { get; set; }
        public virtual DbSet<KeySystem> KeySystem { get; set; }
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
        public virtual DbSet<ViewCustomerDiscount> ViewCustomerDiscount { get; set; }
        public virtual DbSet<ViewCustomerOrderSum> ViewCustomerOrderSum { get; set; }
        public virtual DbSet<ViewCustomerOrderSum30D> ViewCustomerOrderSum30D { get; set; }
        public virtual DbSet<ViewCustomerOrderSumAll> ViewCustomerOrderSumAll { get; set; }
        public virtual DbSet<ViewFoodOffMaxOffDate> ViewFoodOffMaxOffDate { get; set; }
        public virtual DbSet<ViewInvoiceSumDate> ViewInvoiceSumDate { get; set; }
        public virtual DbSet<ViewInvoiceSumMonth> ViewInvoiceSumMonth { get; set; }
        public virtual DbSet<ViewInvoiceSumYear> ViewInvoiceSumYear { get; set; }
        public virtual DbSet<ViewKeyCodeGroup> ViewKeyCodeGroup { get; set; }
        public virtual DbSet<ViewKeySystemGroup> ViewKeySystemGroup { get; set; }
        public virtual DbSet<ViewOrderDetail> ViewOrderDetail { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDate> ViewOrderDetailFoodSumDate { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDay1M> ViewOrderDetailFoodSumDay1M { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDay1Y> ViewOrderDetailFoodSumDay1Y { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDay2M> ViewOrderDetailFoodSumDay2M { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDay2Y> ViewOrderDetailFoodSumDay2Y { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDay3M> ViewOrderDetailFoodSumDay3M { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDay6M> ViewOrderDetailFoodSumDay6M { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumDayAll> ViewOrderDetailFoodSumDayAll { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumMonth> ViewOrderDetailFoodSumMonth { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDay1M> ViewOrderDetailFoodSumWeekDay1M { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDay1W> ViewOrderDetailFoodSumWeekDay1W { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDay1Y> ViewOrderDetailFoodSumWeekDay1Y { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDay2M> ViewOrderDetailFoodSumWeekDay2M { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDay2W> ViewOrderDetailFoodSumWeekDay2W { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDay2Y> ViewOrderDetailFoodSumWeekDay2Y { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDay6M> ViewOrderDetailFoodSumWeekDay6M { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumWeekDayAll> ViewOrderDetailFoodSumWeekDayAll { get; set; }
        public virtual DbSet<ViewOrderDetailFoodSumYear> ViewOrderDetailFoodSumYear { get; set; }
        public virtual DbSet<ViewOrderTypeSumDate> ViewOrderTypeSumDate { get; set; }
        public virtual DbSet<ViewOrderTypeSumMonth> ViewOrderTypeSumMonth { get; set; }
        public virtual DbSet<ViewOrderTypeSumYear> ViewOrderTypeSumYear { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount1M> ViewQuestionnaireAnswerCount1M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount1W> ViewQuestionnaireAnswerCount1W { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount1Y> ViewQuestionnaireAnswerCount1Y { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount2M> ViewQuestionnaireAnswerCount2M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount2W> ViewQuestionnaireAnswerCount2W { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount2Y> ViewQuestionnaireAnswerCount2Y { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCount6M> ViewQuestionnaireAnswerCount6M { get; set; }
        public virtual DbSet<ViewQuestionnaireAnswerCountAll> ViewQuestionnaireAnswerCountAll { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppLogRequest>(entity =>
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

            modelBuilder.Entity<AppLogTable>(entity =>
            {
                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AppSysPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("AppSysPermission_Key");

                entity.HasIndex(e => new { e.ControllerName, e.ActionName })
                    .HasName("AppSysPermission_Index1")
                    .IsUnique();

                entity.HasIndex(e => new { e.HttpApi, e.HttpMethod })
                    .HasName("AppSysPermission_Index2")
                    .IsUnique();

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExternalUrl).HasMaxLength(250);

                entity.Property(e => e.HttpApi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.HttpMethod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PermissionDesc).HasMaxLength(250);

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

                entity.Property(e => e.Note1).HasMaxLength(100);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppSysRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.PermissionId })
                    .HasName("AppSysRolePermission_Key");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AppSysRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppSysRolePermission_AppSysPermission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppSysRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppSysRolePermission_AppSysRole");
            });

            modelBuilder.Entity<AppSysRoleUser>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId })
                    .HasName("AppSysRoleUser_Key");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppSysRoleUser)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppSysRoleUser_AppSysRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppSysRoleUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppSysRoleUser_AppSysUser");
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

                entity.Property(e => e.LoginLastDate).HasColumnType("datetime");

                entity.Property(e => e.MainPhoto).HasMaxLength(250);

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

                entity.Property(e => e.PictureFile).HasMaxLength(100);

                entity.Property(e => e.PicturePath).HasMaxLength(100);

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

                entity.Property(e => e.InvoiceBigMonth)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo1)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.TaxNo).HasMaxLength(30);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Invoice_Customer");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("Invoice_Promotion");
            });

            modelBuilder.Entity<KeyCode>(entity =>
            {
                entity.HasIndex(e => new { e.KeyCodeGroup, e.KeyCodeValue })
                    .HasName("KeyCode_Index1")
                    .IsUnique();

                entity.Property(e => e.KeyCodeGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeyCodeLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeyCodeValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<KeySystem>(entity =>
            {
                entity.Property(e => e.KeySystemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeySystemGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeySystemLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeySystemValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

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

                entity.HasIndex(e => e.WriteTime)
                    .HasName("Questionnaire_Index3");

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

                entity.HasOne(d => d.Invoice)
                    .WithOne(p => p.Questionnaire)
                    .HasForeignKey<Questionnaire>(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Questionnaire_Invoice");
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

            modelBuilder.Entity<ViewInvoiceSumDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewInvoiceSumDate");

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewInvoiceSumMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewInvoiceSumMonth");

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewInvoiceSumYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewInvoiceSumYear");

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewKeyCodeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewKeyCodeGroup");

                entity.Property(e => e.KeyCodeGroup)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewKeySystemGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewKeySystemGroup");

                entity.Property(e => e.KeySystemGroup)
                    .IsRequired()
                    .HasColumnName("keySystemGroup")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetail");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDate");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDay1M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDay1M");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDay1Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDay1Y");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDay2M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDay2M");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDay2Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDay2Y");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDay3M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDay3M");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDay6M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDay6M");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumDayAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumDayAll");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumMonth");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDay1M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDay1M");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDay1W>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDay1W");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDay1Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDay1Y");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDay2M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDay2M");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDay2W>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDay2W");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDay2Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDay2Y");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDay6M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDay6M");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumWeekDayAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumWeekDayAll");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderDetailFoodSumYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderDetailFoodSumYear");

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.FoodType).HasMaxLength(50);

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderTypeSumDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderTypeSumDate");

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("orderType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderTypeSumMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderTypeSumMonth");

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("orderType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOrderTypeSumYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOrderTypeSumYear");

                entity.Property(e => e.GroupUnit)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasColumnName("orderType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount1M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount1M");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount1W>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount1W");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount1Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount1Y");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount2M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount2M");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount2W>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount2W");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount2Y>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount2Y");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCount6M>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCount6M");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewQuestionnaireAnswerCountAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewQuestionnaireAnswerCountAll");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionDesc).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
