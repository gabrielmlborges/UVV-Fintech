using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using UVV_FINTECH.model;

namespace UVV_FINTECH.Data;

public class FintechContext : DbContext
{
    public DbSet<Conta> Contas { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }

    public string DbPath { get; }

    public FintechContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "Data/Fintech.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
