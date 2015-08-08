USE TIGHTLY_CURLY
GO

IF OBJECT_ID('DeleteMessageCampaignById', 'P') IS NOT NULL
BEGIN
	DROP PROCEDURE DeleteMessageCampaignById;
END

GO

CREATE PROCEDURE DeleteMessageCampaignById
	@messageCampaignId int
AS

	DELETE 
	FROM MessageCampaignsSubscriptions
	WHERE MessageCampaignId = @messageCampaignId;

	DELETE 
	FROM MessageCampaigns
	WHERE MessageCampaignId = @messageCampaignId;
 
 