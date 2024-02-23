
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/11/2021 09:25:00
-- Generated from EDMX file: C:\Users\a.moreno\ServiceAppDemo\ServiceAppDemo\ServiceAppDemo\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ServiceApp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__caso__codigo_usu__4E88ABD4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__codigo_usu__4E88ABD4];
GO
IF OBJECT_ID(N'[dbo].[FK__caso__estatus__5441852A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__estatus__5441852A];
GO
IF OBJECT_ID(N'[dbo].[FK__caso__id_cliente__4BAC3F29]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__id_cliente__4BAC3F29];
GO
IF OBJECT_ID(N'[dbo].[FK__caso__id_departa__4F7CD00D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__id_departa__4F7CD00D];
GO
IF OBJECT_ID(N'[dbo].[FK__caso__id_queja__4D94879B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__id_queja__4D94879B];
GO
IF OBJECT_ID(N'[dbo].[FK__caso__id_reclamo__4CA06362]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__id_reclamo__4CA06362];
GO
IF OBJECT_ID(N'[dbo].[FK__caso__relevancia__5535A963]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__relevancia__5535A963];
GO
IF OBJECT_ID(N'[dbo].[FK__caso__tipo_caso__534D60F1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[caso] DROP CONSTRAINT [FK__caso__tipo_caso__534D60F1];
GO
IF OBJECT_ID(N'[dbo].[FK__cliente__estatus__5165187F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[cliente] DROP CONSTRAINT [FK__cliente__estatus__5165187F];
GO
IF OBJECT_ID(N'[dbo].[FK__Operacion__idMod__6383C8BA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Operacion] DROP CONSTRAINT [FK__Operacion__idMod__6383C8BA];
GO
IF OBJECT_ID(N'[dbo].[FK__producto___id_cl__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[producto_cliente] DROP CONSTRAINT [FK__producto___id_cl__4AB81AF0];
GO
IF OBJECT_ID(N'[dbo].[FK__producto___id_pr__49C3F6B7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[producto_cliente] DROP CONSTRAINT [FK__producto___id_pr__49C3F6B7];
GO
IF OBJECT_ID(N'[dbo].[FK__Rol_Opera__idOpe__628FA481]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rol_Operacion] DROP CONSTRAINT [FK__Rol_Opera__idOpe__628FA481];
GO
IF OBJECT_ID(N'[dbo].[FK__Rol_Opera__idrol__66603565]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rol_Operacion] DROP CONSTRAINT [FK__Rol_Opera__idrol__66603565];
GO
IF OBJECT_ID(N'[dbo].[FK__solucion__id_cas__52593CB8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[solucion] DROP CONSTRAINT [FK__solucion__id_cas__52593CB8];
GO
IF OBJECT_ID(N'[dbo].[FK__usuario__estatus__5070F446]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK__usuario__estatus__5070F446];
GO
IF OBJECT_ID(N'[dbo].[FK__usuario__Id_depa__48CFD27E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK__usuario__Id_depa__48CFD27E];
GO
IF OBJECT_ID(N'[dbo].[FK__usuario__idroll__656C112C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [FK__usuario__idroll__656C112C];
GO
IF OBJECT_ID(N'[dbo].[FK__valoracio__id_ca__571DF1D5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[valoracion_respuesta] DROP CONSTRAINT [FK__valoracio__id_ca__571DF1D5];
GO
IF OBJECT_ID(N'[dbo].[FK__valoracio__id_cl__5629CD9C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[valoracion_respuesta] DROP CONSTRAINT [FK__valoracio__id_cl__5629CD9C];
GO
IF OBJECT_ID(N'[dbo].[FK__valoracio__id_us__5812160E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[valoracion_respuesta] DROP CONSTRAINT [FK__valoracio__id_us__5812160E];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[caso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[caso];
GO
IF OBJECT_ID(N'[dbo].[cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cliente];
GO
IF OBJECT_ID(N'[dbo].[departamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[departamento];
GO
IF OBJECT_ID(N'[dbo].[Esta_Usua_clien]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Esta_Usua_clien];
GO
IF OBJECT_ID(N'[dbo].[Estatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estatus];
GO
IF OBJECT_ID(N'[dbo].[modulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[modulo];
GO
IF OBJECT_ID(N'[dbo].[Operacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operacion];
GO
IF OBJECT_ID(N'[dbo].[producto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[producto];
GO
IF OBJECT_ID(N'[dbo].[producto_cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[producto_cliente];
GO
IF OBJECT_ID(N'[dbo].[queja]', 'U') IS NOT NULL
    DROP TABLE [dbo].[queja];
GO
IF OBJECT_ID(N'[dbo].[reclamo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[reclamo];
GO
IF OBJECT_ID(N'[dbo].[Relevancias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Relevancias];
GO
IF OBJECT_ID(N'[dbo].[Rol]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rol];
GO
IF OBJECT_ID(N'[dbo].[Rol_Operacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rol_Operacion];
GO
IF OBJECT_ID(N'[dbo].[solucion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[solucion];
GO
IF OBJECT_ID(N'[dbo].[Tipo_Caso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_Caso];
GO
IF OBJECT_ID(N'[dbo].[usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuario];
GO
IF OBJECT_ID(N'[dbo].[valoracion_respuesta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[valoracion_respuesta];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'casoes'
CREATE TABLE [dbo].[casoes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_cliente] int  NULL,
    [codigo_usuario] nvarchar(30)  NULL,
    [relevancia] nvarchar(3)  NULL,
    [tipo_caso] nvarchar(3)  NULL,
    [id_queja] int  NULL,
    [id_reclamo] int  NULL,
    [id_departamento] int  NULL,
    [fecha] datetime  NULL,
    [Comentario] nvarchar(30)  NULL,
    [estatus] nvarchar(3)  NULL
);
GO

-- Creating table 'clientes'
CREATE TABLE [dbo].[clientes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(30)  NULL,
    [clave] nvarchar(30)  NULL,
    [cedula] nvarchar(30)  NULL,
    [fecha_registro] datetime  NULL,
    [correo] nvarchar(30)  NULL,
    [estatus] nvarchar(3)  NULL,
    [monto] decimal(18,0)  NULL,
    [telefono] nvarchar(30)  NULL,
    [cargo] nvarchar(30)  NULL
);
GO

-- Creating table 'departamentoes'
CREATE TABLE [dbo].[departamentoes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(30)  NULL
);
GO

-- Creating table 'Esta_Usua_clien'
CREATE TABLE [dbo].[Esta_Usua_clien] (
    [CodTip_U_C] nvarchar(3)  NOT NULL,
    [DescripTip_U_C] nvarchar(10)  NULL
);
GO

-- Creating table 'Estatus'
CREATE TABLE [dbo].[Estatus] (
    [CodEst] nvarchar(3)  NOT NULL,
    [DescripEst] nvarchar(10)  NULL
);
GO

-- Creating table 'moduloes'
CREATE TABLE [dbo].[moduloes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(30)  NULL
);
GO

-- Creating table 'Operacions'
CREATE TABLE [dbo].[Operacions] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(30)  NULL,
    [idModulo] int  NULL
);
GO

-- Creating table 'productoes'
CREATE TABLE [dbo].[productoes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(50)  NOT NULL,
    [monto] decimal(14,10)  NULL
);
GO

-- Creating table 'producto_cliente'
CREATE TABLE [dbo].[producto_cliente] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_producto] int  NULL,
    [id_cliente] int  NULL,
    [cantidad] int  NULL
);
GO

-- Creating table 'quejas'
CREATE TABLE [dbo].[quejas] (
    [id] int  NOT NULL,
    [fecha] datetime  NULL
);
GO

-- Creating table 'reclamoes'
CREATE TABLE [dbo].[reclamoes] (
    [id] int  NOT NULL,
    [fecha] datetime  NULL
);
GO

-- Creating table 'Relevancias'
CREATE TABLE [dbo].[Relevancias] (
    [CodRel] nvarchar(3)  NOT NULL,
    [DescripRel] nvarchar(10)  NULL
);
GO

-- Creating table 'Rols'
CREATE TABLE [dbo].[Rols] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(30)  NULL
);
GO

-- Creating table 'Rol_Operacion'
CREATE TABLE [dbo].[Rol_Operacion] (
    [id] int IDENTITY(1,1) NOT NULL,
    [idrol] int  NULL,
    [idOperacion] int  NULL
);
GO

-- Creating table 'solucions'
CREATE TABLE [dbo].[solucions] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_caso] int  NULL,
    [ComenSolu] nvarchar(200)  NULL
);
GO

-- Creating table 'Tipo_Caso'
CREATE TABLE [dbo].[Tipo_Caso] (
    [CodTip] nvarchar(3)  NOT NULL,
    [DescripTip] nvarchar(10)  NULL
);
GO

-- Creating table 'usuarios'
CREATE TABLE [dbo].[usuarios] (
    [codigo] nvarchar(30)  NOT NULL,
    [nombre] nvarchar(30)  NULL,
    [clave] nvarchar(30)  NULL,
    [estatus] nvarchar(3)  NULL,
    [Id_departamento] int  NULL,
    [cargo] nvarchar(30)  NULL,
    [idroll] int  NULL,
    [fecha] datetime  NULL,
    [TipoUser] nvarchar(3)  NULL
);
GO

-- Creating table 'valoracion_respuesta'
CREATE TABLE [dbo].[valoracion_respuesta] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_caso] int  NULL,
    [id_cliente] int  NULL,
    [id_usuario] nvarchar(30)  NULL,
    [valor] decimal(18,0)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [PK_casoes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'clientes'
ALTER TABLE [dbo].[clientes]
ADD CONSTRAINT [PK_clientes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'departamentoes'
ALTER TABLE [dbo].[departamentoes]
ADD CONSTRAINT [PK_departamentoes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [CodTip_U_C] in table 'Esta_Usua_clien'
ALTER TABLE [dbo].[Esta_Usua_clien]
ADD CONSTRAINT [PK_Esta_Usua_clien]
    PRIMARY KEY CLUSTERED ([CodTip_U_C] ASC);
GO

-- Creating primary key on [CodEst] in table 'Estatus'
ALTER TABLE [dbo].[Estatus]
ADD CONSTRAINT [PK_Estatus]
    PRIMARY KEY CLUSTERED ([CodEst] ASC);
GO

-- Creating primary key on [id] in table 'moduloes'
ALTER TABLE [dbo].[moduloes]
ADD CONSTRAINT [PK_moduloes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Operacions'
ALTER TABLE [dbo].[Operacions]
ADD CONSTRAINT [PK_Operacions]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'productoes'
ALTER TABLE [dbo].[productoes]
ADD CONSTRAINT [PK_productoes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'producto_cliente'
ALTER TABLE [dbo].[producto_cliente]
ADD CONSTRAINT [PK_producto_cliente]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'quejas'
ALTER TABLE [dbo].[quejas]
ADD CONSTRAINT [PK_quejas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'reclamoes'
ALTER TABLE [dbo].[reclamoes]
ADD CONSTRAINT [PK_reclamoes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [CodRel] in table 'Relevancias'
ALTER TABLE [dbo].[Relevancias]
ADD CONSTRAINT [PK_Relevancias]
    PRIMARY KEY CLUSTERED ([CodRel] ASC);
GO

-- Creating primary key on [id] in table 'Rols'
ALTER TABLE [dbo].[Rols]
ADD CONSTRAINT [PK_Rols]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Rol_Operacion'
ALTER TABLE [dbo].[Rol_Operacion]
ADD CONSTRAINT [PK_Rol_Operacion]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'solucions'
ALTER TABLE [dbo].[solucions]
ADD CONSTRAINT [PK_solucions]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [CodTip] in table 'Tipo_Caso'
ALTER TABLE [dbo].[Tipo_Caso]
ADD CONSTRAINT [PK_Tipo_Caso]
    PRIMARY KEY CLUSTERED ([CodTip] ASC);
GO

-- Creating primary key on [codigo] in table 'usuarios'
ALTER TABLE [dbo].[usuarios]
ADD CONSTRAINT [PK_usuarios]
    PRIMARY KEY CLUSTERED ([codigo] ASC);
GO

-- Creating primary key on [id] in table 'valoracion_respuesta'
ALTER TABLE [dbo].[valoracion_respuesta]
ADD CONSTRAINT [PK_valoracion_respuesta]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [codigo_usuario] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK__caso__codigo_usu__60A75C0F]
    FOREIGN KEY ([codigo_usuario])
    REFERENCES [dbo].[usuarios]
        ([codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__caso__codigo_usu__60A75C0F'
CREATE INDEX [IX_FK__caso__codigo_usu__60A75C0F]
ON [dbo].[casoes]
    ([codigo_usuario]);
GO

-- Creating foreign key on [estatus] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK__caso__estatus__6A30C649]
    FOREIGN KEY ([estatus])
    REFERENCES [dbo].[Estatus]
        ([CodEst])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__caso__estatus__6A30C649'
CREATE INDEX [IX_FK__caso__estatus__6A30C649]
ON [dbo].[casoes]
    ([estatus]);
GO

-- Creating foreign key on [id_cliente] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK__caso__id_cliente__5DCAEF64]
    FOREIGN KEY ([id_cliente])
    REFERENCES [dbo].[clientes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__caso__id_cliente__5DCAEF64'
CREATE INDEX [IX_FK__caso__id_cliente__5DCAEF64]
ON [dbo].[casoes]
    ([id_cliente]);
GO

-- Creating foreign key on [id_queja] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK__caso__id_queja__5FB337D6]
    FOREIGN KEY ([id_queja])
    REFERENCES [dbo].[quejas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__caso__id_queja__5FB337D6'
CREATE INDEX [IX_FK__caso__id_queja__5FB337D6]
ON [dbo].[casoes]
    ([id_queja]);
GO

-- Creating foreign key on [id_reclamo] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK__caso__id_reclamo__5EBF139D]
    FOREIGN KEY ([id_reclamo])
    REFERENCES [dbo].[reclamoes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__caso__id_reclamo__5EBF139D'
CREATE INDEX [IX_FK__caso__id_reclamo__5EBF139D]
ON [dbo].[casoes]
    ([id_reclamo]);
GO

-- Creating foreign key on [relevancia] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK__caso__relevancia__6B24EA82]
    FOREIGN KEY ([relevancia])
    REFERENCES [dbo].[Relevancias]
        ([CodRel])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__caso__relevancia__6B24EA82'
CREATE INDEX [IX_FK__caso__relevancia__6B24EA82]
ON [dbo].[casoes]
    ([relevancia]);
GO

-- Creating foreign key on [tipo_caso] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK__caso__tipo_caso__693CA210]
    FOREIGN KEY ([tipo_caso])
    REFERENCES [dbo].[Tipo_Caso]
        ([CodTip])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__caso__tipo_caso__693CA210'
CREATE INDEX [IX_FK__caso__tipo_caso__693CA210]
ON [dbo].[casoes]
    ([tipo_caso]);
GO

-- Creating foreign key on [id_caso] in table 'solucions'
ALTER TABLE [dbo].[solucions]
ADD CONSTRAINT [FK__solucion__id_cas__6754599E]
    FOREIGN KEY ([id_caso])
    REFERENCES [dbo].[casoes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__solucion__id_cas__6754599E'
CREATE INDEX [IX_FK__solucion__id_cas__6754599E]
ON [dbo].[solucions]
    ([id_caso]);
GO

-- Creating foreign key on [id_caso] in table 'valoracion_respuesta'
ALTER TABLE [dbo].[valoracion_respuesta]
ADD CONSTRAINT [FK__valoracio__id_ca__6D0D32F4]
    FOREIGN KEY ([id_caso])
    REFERENCES [dbo].[casoes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__valoracio__id_ca__6D0D32F4'
CREATE INDEX [IX_FK__valoracio__id_ca__6D0D32F4]
ON [dbo].[valoracion_respuesta]
    ([id_caso]);
GO

-- Creating foreign key on [id_departamento] in table 'casoes'
ALTER TABLE [dbo].[casoes]
ADD CONSTRAINT [FK_User__depart]
    FOREIGN KEY ([id_departamento])
    REFERENCES [dbo].[departamentoes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User__depart'
CREATE INDEX [IX_FK_User__depart]
ON [dbo].[casoes]
    ([id_departamento]);
GO

-- Creating foreign key on [estatus] in table 'clientes'
ALTER TABLE [dbo].[clientes]
ADD CONSTRAINT [FK__cliente__estatus__66603565]
    FOREIGN KEY ([estatus])
    REFERENCES [dbo].[Esta_Usua_clien]
        ([CodTip_U_C])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__cliente__estatus__66603565'
CREATE INDEX [IX_FK__cliente__estatus__66603565]
ON [dbo].[clientes]
    ([estatus]);
GO

-- Creating foreign key on [id_cliente] in table 'producto_cliente'
ALTER TABLE [dbo].[producto_cliente]
ADD CONSTRAINT [FK__producto___id_cl__5CD6CB2B]
    FOREIGN KEY ([id_cliente])
    REFERENCES [dbo].[clientes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__producto___id_cl__5CD6CB2B'
CREATE INDEX [IX_FK__producto___id_cl__5CD6CB2B]
ON [dbo].[producto_cliente]
    ([id_cliente]);
GO

-- Creating foreign key on [id_cliente] in table 'valoracion_respuesta'
ALTER TABLE [dbo].[valoracion_respuesta]
ADD CONSTRAINT [FK__valoracio__id_cl__6C190EBB]
    FOREIGN KEY ([id_cliente])
    REFERENCES [dbo].[clientes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__valoracio__id_cl__6C190EBB'
CREATE INDEX [IX_FK__valoracio__id_cl__6C190EBB]
ON [dbo].[valoracion_respuesta]
    ([id_cliente]);
GO

-- Creating foreign key on [Id_departamento] in table 'usuarios'
ALTER TABLE [dbo].[usuarios]
ADD CONSTRAINT [FK__usuario__Id_depa__5AEE82B9]
    FOREIGN KEY ([Id_departamento])
    REFERENCES [dbo].[departamentoes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__usuario__Id_depa__5AEE82B9'
CREATE INDEX [IX_FK__usuario__Id_depa__5AEE82B9]
ON [dbo].[usuarios]
    ([Id_departamento]);
GO

-- Creating foreign key on [estatus] in table 'usuarios'
ALTER TABLE [dbo].[usuarios]
ADD CONSTRAINT [FK__usuario__estatus__656C112C]
    FOREIGN KEY ([estatus])
    REFERENCES [dbo].[Esta_Usua_clien]
        ([CodTip_U_C])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__usuario__estatus__656C112C'
CREATE INDEX [IX_FK__usuario__estatus__656C112C]
ON [dbo].[usuarios]
    ([estatus]);
GO

-- Creating foreign key on [idModulo] in table 'Operacions'
ALTER TABLE [dbo].[Operacions]
ADD CONSTRAINT [FK__Operacion__idMod__59063A47]
    FOREIGN KEY ([idModulo])
    REFERENCES [dbo].[moduloes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Operacion__idMod__59063A47'
CREATE INDEX [IX_FK__Operacion__idMod__59063A47]
ON [dbo].[Operacions]
    ([idModulo]);
GO

-- Creating foreign key on [idOperacion] in table 'Rol_Operacion'
ALTER TABLE [dbo].[Rol_Operacion]
ADD CONSTRAINT [FK__Rol_Opera__idOpe__5812160E]
    FOREIGN KEY ([idOperacion])
    REFERENCES [dbo].[Operacions]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Rol_Opera__idOpe__5812160E'
CREATE INDEX [IX_FK__Rol_Opera__idOpe__5812160E]
ON [dbo].[Rol_Operacion]
    ([idOperacion]);
GO

-- Creating foreign key on [id_producto] in table 'producto_cliente'
ALTER TABLE [dbo].[producto_cliente]
ADD CONSTRAINT [FK__producto___id_pr__5BE2A6F2]
    FOREIGN KEY ([id_producto])
    REFERENCES [dbo].[productoes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__producto___id_pr__5BE2A6F2'
CREATE INDEX [IX_FK__producto___id_pr__5BE2A6F2]
ON [dbo].[producto_cliente]
    ([id_producto]);
GO

-- Creating foreign key on [idrol] in table 'Rol_Operacion'
ALTER TABLE [dbo].[Rol_Operacion]
ADD CONSTRAINT [FK__Rol_Opera__idrol__571DF1D5]
    FOREIGN KEY ([idrol])
    REFERENCES [dbo].[Rols]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Rol_Opera__idrol__571DF1D5'
CREATE INDEX [IX_FK__Rol_Opera__idrol__571DF1D5]
ON [dbo].[Rol_Operacion]
    ([idrol]);
GO

-- Creating foreign key on [idroll] in table 'usuarios'
ALTER TABLE [dbo].[usuarios]
ADD CONSTRAINT [FK__usuario__idroll__59FA5E80]
    FOREIGN KEY ([idroll])
    REFERENCES [dbo].[Rols]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__usuario__idroll__59FA5E80'
CREATE INDEX [IX_FK__usuario__idroll__59FA5E80]
ON [dbo].[usuarios]
    ([idroll]);
GO

-- Creating foreign key on [id_usuario] in table 'valoracion_respuesta'
ALTER TABLE [dbo].[valoracion_respuesta]
ADD CONSTRAINT [FK__valoracio__id_us__6E01572D]
    FOREIGN KEY ([id_usuario])
    REFERENCES [dbo].[usuarios]
        ([codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__valoracio__id_us__6E01572D'
CREATE INDEX [IX_FK__valoracio__id_us__6E01572D]
ON [dbo].[valoracion_respuesta]
    ([id_usuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------