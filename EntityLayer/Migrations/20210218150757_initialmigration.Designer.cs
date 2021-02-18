﻿// <auto-generated />
using System;
using EntityLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210218150757_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankCreditCustomerProfile", b =>
                {
                    b.Property<int>("BankCreditsId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.HasKey("BankCreditsId", "CustomerProfilesId");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("BankCreditCustomerProfile");
                });

            modelBuilder.Entity("BankDebitCustomerProfile", b =>
                {
                    b.Property<int>("BankDebitsId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.HasKey("BankDebitsId", "CustomerProfilesId");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("BankDebitCustomerProfile");
                });

            modelBuilder.Entity("CashDepositCustomerProfile", b =>
                {
                    b.Property<int>("CashDepositsId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.HasKey("CashDepositsId", "CustomerProfilesId");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("CashDepositCustomerProfile");
                });

            modelBuilder.Entity("CustomerProfileDebitCardIssuance", b =>
                {
                    b.Property<int>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.Property<int>("DebitCardIssuancesId")
                        .HasColumnType("int");

                    b.HasKey("CustomerProfilesId", "DebitCardIssuancesId");

                    b.HasIndex("DebitCardIssuancesId");

                    b.ToTable("CustomerProfileDebitCardIssuance");
                });

            modelBuilder.Entity("EntityLayer.BankProfitAndLoss.BankCredit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BankCreditAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BankCredits");
                });

            modelBuilder.Entity("EntityLayer.BankProfitAndLoss.BankDebit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BankDebitAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BankDebits");
                });

            modelBuilder.Entity("EntityLayer.CashDeposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumberOfRecipient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AmountInWords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepositDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumberOfDepositor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CashDeposits");
                });

            modelBuilder.Entity("EntityLayer.CustomerDetails.CustomerProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressOfNextOfKin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("CustomerImage")
                        .HasColumnType("tinyint");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NameOfNextOfKin")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherNames")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberOfNextOfKin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("CustomerProfiles");
                });

            modelBuilder.Entity("EntityLayer.DebitCardIssuance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cvv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("debitCardIssuances");
                });

            modelBuilder.Entity("EntityLayer.DomCustomer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressOfNextOfKin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currencies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("CustomerImage")
                        .HasColumnType("tinyint");

                    b.Property<int?>("CustomerProfilesId")
                        .HasColumnType("int");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NameOfNextOfKin")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherNames")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberOfNextOfKin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerProfilesId");

                    b.ToTable("DomCustomers");
                });

            modelBuilder.Entity("EntityLayer.FixDeposit.FixedDeposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountDue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Interest")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Principal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("Time")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("FixedDeposits");
                });

            modelBuilder.Entity("EntityLayer.Loans.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InterestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPayment")
                        .HasColumnType("int");

                    b.Property<DateTime>("RepaymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Tenor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("EntityLayer.SavingsAccount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AccountCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("AccountOwnerID")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("SavingsAccounts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SavingsAccount");
                });

            modelBuilder.Entity("EntityLayer.TransactionHistory", b =>
                {
                    b.HasBaseType("EntityLayer.SavingsAccount");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionAmount")
                        .HasColumnType("int");

                    b.Property<string>("TransactionComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionHistorySearchPeriod")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionRecipientBankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionRecipientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("TransactionHistory");
                });

            modelBuilder.Entity("BankCreditCustomerProfile", b =>
                {
                    b.HasOne("EntityLayer.BankProfitAndLoss.BankCredit", null)
                        .WithMany()
                        .HasForeignKey("BankCreditsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BankDebitCustomerProfile", b =>
                {
                    b.HasOne("EntityLayer.BankProfitAndLoss.BankDebit", null)
                        .WithMany()
                        .HasForeignKey("BankDebitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CashDepositCustomerProfile", b =>
                {
                    b.HasOne("EntityLayer.CashDeposit", null)
                        .WithMany()
                        .HasForeignKey("CashDepositsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerProfileDebitCardIssuance", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", null)
                        .WithMany()
                        .HasForeignKey("CustomerProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.DebitCardIssuance", null)
                        .WithMany()
                        .HasForeignKey("DebitCardIssuancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.DomCustomer", b =>
                {
                    b.HasOne("EntityLayer.CustomerDetails.CustomerProfile", "CustomerProfiles")
                        .WithMany("DomCustomers")
                        .HasForeignKey("CustomerProfilesId");

                    b.Navigation("CustomerProfiles");
                });

            modelBuilder.Entity("EntityLayer.CustomerDetails.CustomerProfile", b =>
                {
                    b.Navigation("DomCustomers");
                });
#pragma warning restore 612, 618
        }
    }
}
