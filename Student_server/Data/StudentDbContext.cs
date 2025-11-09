using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Studen_server.Models;

namespace Studen_server.Data;

public partial class StudentDbContext : DbContext
{
    public StudentDbContext()
    {
    }

    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblDangKyHocPhan> TblDangKyHocPhans { get; set; }

    public virtual DbSet<TblDiem> TblDiems { get; set; }

    public virtual DbSet<TblHocKy> TblHocKies { get; set; }

    public virtual DbSet<TblLop> TblLops { get; set; }

    public virtual DbSet<TblLopHocPhan> TblLopHocPhans { get; set; }

    public virtual DbSet<TblMonHoc> TblMonHocs { get; set; }

    public virtual DbSet<TblSinhVien> TblSinhViens { get; set; }

    public virtual DbSet<TblTaiKhoan> TblTaiKhoans { get; set; }

    public virtual DbSet<VDanhSachLopHocPhanDangMo> VDanhSachLopHocPhanDangMos { get; set; }

    public virtual DbSet<VThongKeKetQuaTheoMon> VThongKeKetQuaTheoMons { get; set; }

    public virtual DbSet<VThongKeSinhVienTheoLop> VThongKeSinhVienTheoLops { get; set; }

    public virtual DbSet<VXepHangSinhVien> VXepHangSinhViens { get; set; }
    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=KIEN;Database=QuanLySinhVien;Trusted_Connection=True;TrustServerCertificate=True");
    */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Vietnamese_CI_AS");

        modelBuilder.Entity<TblDangKyHocPhan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_Dang__3214EC276CBB2E06");

            entity.ToTable("tbl_DangKyHocPhan", tb =>
                {
                    tb.HasTrigger("trg_CapNhatSoSVDangKy_Delete");
                    tb.HasTrigger("trg_CapNhatSoSVDangKy_Insert");
                    tb.HasTrigger("trg_CapNhatSoSVDangKy_Update");
                    tb.HasTrigger("trg_TaoBanGhiDiem");
                });

            entity.HasIndex(e => e.MaLopHp, "idx_malophp");

            entity.HasIndex(e => e.MaSv, "idx_masv");

            entity.HasIndex(e => new { e.MaSv, e.MaLopHp }, "unique_dangky").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLopHp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaLopHP");
            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.NgayDangKy)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TrangThaiDangKy)
                .HasMaxLength(10)
                .HasDefaultValue("Chờ duyệt");

            entity.HasOne(d => d.MaLopHpNavigation).WithMany(p => p.TblDangKyHocPhans)
                .HasForeignKey(d => d.MaLopHp)
                .HasConstraintName("FK__tbl_DangK__MaLop__5DCAEF64");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.TblDangKyHocPhans)
                .HasForeignKey(d => d.MaSv)
                .HasConstraintName("FK__tbl_DangKy__MaSV__5CD6CB2B");
        });

        modelBuilder.Entity<TblDiem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_Diem__3214EC2773985005");

            entity.ToTable("tbl_Diem");

            entity.HasIndex(e => e.MaLopHp, "idx_malophp_diem");

            entity.HasIndex(e => e.MaSv, "idx_masv_diem");

            entity.HasIndex(e => new { e.MaSv, e.MaLopHp }, "unique_diem").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiemChu)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(9.0) then 'A+' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(8.5) then 'A' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(8.0) then 'B+' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(7.0) then 'B' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(6.5) then 'C+' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(5.5) then 'C' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(5.0) then 'D+' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(4.0) then 'D' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6)) IS NOT NULL then 'F'  end)", false);
            entity.Property(e => e.DiemChuyenCan)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(3, 1)");
            entity.Property(e => e.DiemCuoiKy)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(3, 1)");
            entity.Property(e => e.DiemGiuaKy)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(3, 1)");
            entity.Property(e => e.DiemTongKet)
                .HasComputedColumnSql("(CONVERT([decimal](3,1),case when [DiemChuyenCan] IS NOT NULL AND [DiemGiuaKy] IS NOT NULL AND [DiemCuoiKy] IS NOT NULL then ([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6)  end))", false)
                .HasColumnType("decimal(3, 1)");
            entity.Property(e => e.KetQua)
                .HasMaxLength(9)
                .HasComputedColumnSql("(case when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6))>=(4.0) then N'Đạt' when (([DiemChuyenCan]*(0.1)+[DiemGiuaKy]*(0.3))+[DiemCuoiKy]*(0.6)) IS NOT NULL then N'Không đạt' else N'Chưa có' end)", false);
            entity.Property(e => e.MaLopHp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaLopHP");
            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.NgayCapNhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.MaLopHpNavigation).WithMany(p => p.TblDiems)
                .HasForeignKey(d => d.MaLopHp)
                .HasConstraintName("FK__tbl_Diem__MaLopH__693CA210");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.TblDiems)
                .HasForeignKey(d => d.MaSv)
                .HasConstraintName("FK__tbl_Diem__MaSV__68487DD7");
        });

        modelBuilder.Entity<TblHocKy>(entity =>
        {
            entity.HasKey(e => e.MaHocKy).HasName("PK__tbl_HocK__1EB551105033FF50");

            entity.ToTable("tbl_HocKy");

            entity.HasIndex(e => new { e.TenHocKy, e.NamHoc }, "unique_hocky").IsUnique();

            entity.Property(e => e.MaHocKy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NamHoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(20)
                .HasDefaultValue("Sắp diễn ra");
        });

        modelBuilder.Entity<TblLop>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK__tbl_Lop__3B98D2738AFAC682");

            entity.ToTable("tbl_Lop");

            entity.HasIndex(e => new { e.TenLop, e.NienKhoa }, "unique_lop").IsUnique();

            entity.Property(e => e.MaLop)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Khoa).HasMaxLength(100);
            entity.Property(e => e.NienKhoa)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenLop).HasMaxLength(100);
        });

        modelBuilder.Entity<TblLopHocPhan>(entity =>
        {
            entity.HasKey(e => e.MaLopHp).HasName("PK__tbl_LopH__976ACA320DDFB058");

            entity.ToTable("tbl_LopHocPhan");

            entity.HasIndex(e => new { e.MaMonHoc, e.MaHocKy }, "idx_monhoc_hocky");

            entity.Property(e => e.MaLopHp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaLopHP");
            entity.Property(e => e.GiangVien).HasMaxLength(100);
            entity.Property(e => e.LichHoc).HasMaxLength(255);
            entity.Property(e => e.MaHocKy)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaMonHoc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhongHoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SoChoToiDa).HasDefaultValue(50);
            entity.Property(e => e.SoSinhVienDaDk)
                .HasDefaultValue(0)
                .HasColumnName("SoSinhVienDaDK");
            entity.Property(e => e.TenLopHp)
                .HasMaxLength(100)
                .HasColumnName("TenLopHP");

            entity.HasOne(d => d.MaHocKyNavigation).WithMany(p => p.TblLopHocPhans)
                .HasForeignKey(d => d.MaHocKy)
                .HasConstraintName("FK__tbl_LopHo__MaHoc__5629CD9C");

            entity.HasOne(d => d.MaMonHocNavigation).WithMany(p => p.TblLopHocPhans)
                .HasForeignKey(d => d.MaMonHoc)
                .HasConstraintName("FK__tbl_LopHo__MaMon__5535A963");
        });

        modelBuilder.Entity<TblMonHoc>(entity =>
        {
            entity.HasKey(e => e.MaMonHoc).HasName("PK__tbl_MonH__4127737FC4B6F807");

            entity.ToTable("tbl_MonHoc");

            entity.HasIndex(e => e.TenMonHoc, "UQ__tbl_MonH__AB9BBBD681DE9857").IsUnique();

            entity.HasIndex(e => e.TenMonHoc, "idx_tenmonhoc");

            entity.Property(e => e.MaMonHoc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MonHocTienQuyet)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenMonHoc).HasMaxLength(150);

            entity.HasOne(d => d.MonHocTienQuyetNavigation).WithMany(p => p.InverseMonHocTienQuyetNavigation)
                .HasForeignKey(d => d.MonHocTienQuyet)
                .HasConstraintName("FK__tbl_MonHo__MonHo__5070F446");
        });

        modelBuilder.Entity<TblSinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__tbl_Sinh__2725081A89A38FD6");

            entity.ToTable("tbl_SinhVien");

            entity.HasIndex(e => e.HoTen, "idx_hoten");

            entity.HasIndex(e => e.MaLop, "idx_malop");

            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(5)
                .HasDefaultValue("Nam");
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.MaLop)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayNhapHoc).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(20)
                .HasDefaultValue("Đang học");

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.TblSinhViens)
                .HasForeignKey(d => d.MaLop)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__tbl_SinhV__MaLop__3F466844");
        });

        modelBuilder.Entity<TblTaiKhoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_TaiK__3214EC27DA339EBB");

            entity.ToTable("tbl_TaiKhoan");

            entity.HasIndex(e => e.TenDangNhap, "UQ__tbl_TaiK__55F68FC0DE7F645D").IsUnique();

            entity.HasIndex(e => e.TenDangNhap, "idx_tendangnhap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LanDangNhapCuoi).HasColumnType("datetime");
            entity.Property(e => e.LoaiTaiKhoan).HasMaxLength(10);
            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(10)
                .HasDefaultValue("Hoạt động");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.TblTaiKhoans)
                .HasForeignKey(d => d.MaSv)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__tbl_TaiKho__MaSV__46E78A0C");
        });

        modelBuilder.Entity<VDanhSachLopHocPhanDangMo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DanhSachLopHocPhanDangMo");

            entity.Property(e => e.GiangVien).HasMaxLength(100);
            entity.Property(e => e.LichHoc).HasMaxLength(255);
            entity.Property(e => e.MaLopHp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaLopHP");
            entity.Property(e => e.MaMonHoc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NamHoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhongHoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SoSinhVienDaDk).HasColumnName("SoSinhVienDaDK");
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
            entity.Property(e => e.TenLopHp)
                .HasMaxLength(100)
                .HasColumnName("TenLopHP");
            entity.Property(e => e.TenMonHoc).HasMaxLength(150);
        });

        modelBuilder.Entity<VThongKeKetQuaTheoMon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ThongKeKetQuaTheoMon");

            entity.Property(e => e.DiemTrungBinh).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.MaMonHoc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NamHoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
            entity.Property(e => e.TenMonHoc).HasMaxLength(150);
        });

        modelBuilder.Entity<VThongKeSinhVienTheoLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ThongKeSinhVienTheoLop");

            entity.Property(e => e.Khoa).HasMaxLength(100);
            entity.Property(e => e.MaLop)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NienKhoa)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenLop).HasMaxLength(100);
        });

        modelBuilder.Entity<VXepHangSinhVien>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_XepHangSinhVien");

            entity.Property(e => e.DiemTrungBinh).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.TenLop).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
