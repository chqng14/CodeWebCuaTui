﻿// <auto-generated />
using System;
using CodeWebCuaTui.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeWebCuaTui.Migrations
{
    [DbContext(typeof(CodeWebCuaTuiDbContex))]
    [Migration("20230313022312_Chang")]
    partial class Chang
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeWebCuaTui.Models.Anh", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChiTietSpID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Duongdan")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("IDctsp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ChiTietSpID");

                    b.ToTable("Anh", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.ChiTietGioHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDCtsp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDCtsp");

                    b.HasIndex("IDUser");

                    b.ToTable("ChiTietGioHang", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.ChiTietHoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("Decimal");

                    b.Property<Guid>("IDChiTietSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDChiTietSP");

                    b.HasIndex("IDHoaDon");

                    b.ToTable("ChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.ChiTietSp", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("Decimal");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("Decimal");

                    b.Property<Guid>("IDKichCo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNhaSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDTheLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDKichCo");

                    b.HasIndex("IDMauSac");

                    b.HasIndex("IDNhaSX");

                    b.HasIndex("IDSanPham");

                    b.HasIndex("IDTheLoai");

                    b.ToTable("ChiTietSp", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.GioHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("NguoiDungID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("NguoiDungID");

                    b.ToTable("GioHang", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("IDPTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("Datetime");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("Datetime");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenNguoiNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("Decimal");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<int>("TrangThaiGiaoHang")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDPTTT");

                    b.HasIndex("IDUser");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.KichCo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KichCo", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.MauSac", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MauSac", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.NguoiDung", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("IdVaiTro")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("Datetime");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("TenDem")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdVaiTro");

                    b.ToTable("NguoiDung", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.NhaSanXuat", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("NhaSanXuat", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.PhuongThucThanhToan", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PhuongThucThanhToan", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.TheLoai", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TheLoai", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.VaiTro", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("TenVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("VaiTro", (string)null);
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.Anh", b =>
                {
                    b.HasOne("CodeWebCuaTui.Models.ChiTietSp", "ChiTietSp")
                        .WithMany("Anhs")
                        .HasForeignKey("ChiTietSpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSp");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.ChiTietGioHang", b =>
                {
                    b.HasOne("CodeWebCuaTui.Models.ChiTietSp", "ChiTietSp")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("IDCtsp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk_ctsp");

                    b.HasOne("CodeWebCuaTui.Models.GioHang", "GioHang")
                        .WithMany("ChitietGioHang")
                        .HasForeignKey("IDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk_GioHang");

                    b.Navigation("ChiTietSp");

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("CodeWebCuaTui.Models.ChiTietSp", "ChiTietSp")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("IDChiTietSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_ctspp");

                    b.HasOne("CodeWebCuaTui.Models.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_hoadon");

                    b.Navigation("ChiTietSp");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.ChiTietSp", b =>
                {
                    b.HasOne("CodeWebCuaTui.Models.KichCo", "KichCos")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IDKichCo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_kichco");

                    b.HasOne("CodeWebCuaTui.Models.MauSac", "MauSac")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IDMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_mausac");

                    b.HasOne("CodeWebCuaTui.Models.NhaSanXuat", "NhaSanXuat")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IDNhaSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_nxs");

                    b.HasOne("CodeWebCuaTui.Models.SanPham", "SanPham")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_sp");

                    b.HasOne("CodeWebCuaTui.Models.TheLoai", "TheLoai")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IDTheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_theloai");

                    b.Navigation("KichCos");

                    b.Navigation("MauSac");

                    b.Navigation("NhaSanXuat");

                    b.Navigation("SanPham");

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.GioHang", b =>
                {
                    b.HasOne("CodeWebCuaTui.Models.NguoiDung", "NguoiDung")
                        .WithMany("GioHang")
                        .HasForeignKey("NguoiDungID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.HoaDon", b =>
                {
                    b.HasOne("CodeWebCuaTui.Models.PhuongThucThanhToan", "PhuongThucThanhToan")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDPTTT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_pttt");

                    b.HasOne("CodeWebCuaTui.Models.NguoiDung", "NguoiDung")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user");

                    b.Navigation("NguoiDung");

                    b.Navigation("PhuongThucThanhToan");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.NguoiDung", b =>
                {
                    b.HasOne("CodeWebCuaTui.Models.VaiTro", "VaiTro")
                        .WithMany("NguoiDung")
                        .HasForeignKey("IdVaiTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_vaitro");

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.ChiTietSp", b =>
                {
                    b.Navigation("Anhs");

                    b.Navigation("ChiTietGioHangs");

                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.GioHang", b =>
                {
                    b.Navigation("ChitietGioHang");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.KichCo", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.MauSac", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.NguoiDung", b =>
                {
                    b.Navigation("GioHang");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.NhaSanXuat", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.PhuongThucThanhToan", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.TheLoai", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("CodeWebCuaTui.Models.VaiTro", b =>
                {
                    b.Navigation("NguoiDung");
                });
#pragma warning restore 612, 618
        }
    }
}
