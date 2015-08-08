USE TIGHTLY_CURLY
GO

IF OBJECT_ID('GetAllMessageCampaigns', 'P') IS NOT NULL
BEGIN
	DROP PROCEDURE GetAllMessageCampaigns;
END

GO

CREATE PROCEDURE GetAllMessageCampaigns
AS

	SELECT	MessageCampaigns.MessageCampaignId,
			MessageCampaigns.CampaignName,
			MessageCampaigns.Description,
			MessageCampaigns.MessageTemplateId,
			MessageCampaigns.EnteredDate,
			MessageCampaigns.UpdatedDate,
			MessageCampaignsSubscriptions.SubscriptionId
	FROM	MessageCampaigns (NOLOCK) INNER JOIN MessageCampaignsSubscriptions (NOLOCK)
	ON		MessageCampaigns.MessageCampaignId = MessageCampaignsSubscriptions.MessageCampaignId;