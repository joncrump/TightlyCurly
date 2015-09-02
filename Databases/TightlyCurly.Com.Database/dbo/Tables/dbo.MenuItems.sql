CREATE TABLE [dbo].[MenuItems]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[MenuItemId] UNIQUEIDENTIFIER NOT NULL,
	[ParentId] UNIQUEIDENTIFIER NULL,
	[Order] INT NULL,
	[Uri] NVARCHAR(1000) NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
	/*
	Guid? ParentId { get; set; }
        IMenuItem Parent { get; set; }
        IEnumerable<IMenuItemText> MenuItemTexts { get; set; }
        int? Order { get; set; }
        IEnumerable<IMenuItem> Children { get; set; }
        IEnumerable<IMenu> Menus { get; set; }
        Uri Uri { get; set; }
	*/
)
