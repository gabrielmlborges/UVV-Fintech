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
        var folder = Enviornment.SpecialFolder.LocalApplicationData;
        var path = Enviornment.GetFolderPath(folder);
        DbPath = Path.Join(path, "Fintech.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
