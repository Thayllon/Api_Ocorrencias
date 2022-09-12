IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Pedido] (
    [IdPedido] int NOT NULL IDENTITY,
    [NumeroPedido] int NOT NULL,
    [HoraPedido] datetime2 NOT NULL,
    [IndCancelado] bit NOT NULL,
    [IndConcluido] bit NOT NULL,
    CONSTRAINT [PK_Pedido] PRIMARY KEY ([IdPedido])
);

GO

CREATE TABLE [Ocorrencia] (
    [IdOcorrencia] int NOT NULL IDENTITY,
    [TipoOcorrencia] nvarchar(max) NOT NULL,
    [HoraOcorrencia] datetime2 NOT NULL,
    [IndFinalizadora] bit NOT NULL,
    [PedidoIdPedido] int NOT NULL,
    CONSTRAINT [PK_Ocorrencia] PRIMARY KEY ([IdOcorrencia]),
    CONSTRAINT [FK_Ocorrencia_Pedido_PedidoIdPedido] FOREIGN KEY ([PedidoIdPedido]) REFERENCES [Pedido] ([IdPedido]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Ocorrencia_PedidoIdPedido] ON [Ocorrencia] ([PedidoIdPedido]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220904215705_First', N'3.1.28');

GO

