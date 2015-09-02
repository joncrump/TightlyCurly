// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IMenuText, TightlyCurly.Com.Common.Models",
            "dataSource": "dbo.MenuTexts",
            "countProperty":"Id",
            "propertyMappings:": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "MenuTextId",
                "allowDbNull": false,
                "isPrimaryKey": true
            },
            {
                "propertyName": "EnteredDate",
                "fieldType": "smalldatetime",
                "field": "EnteredDate"
            },
            {
                "propertyName": "UpdatedDate",
                "fieldType": "smalldatetime",
                "field": "UpdatedDate"
            }]

        /*
        	/*
	        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid MenuId { get; set; }
        public Guid LocaleId { get; set; }
        public ILocale Locale { get; set; }
        public string Text { get; set; }
	*/
    }
]