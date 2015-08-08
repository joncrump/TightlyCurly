USE TIGHTLY_CURLY
GO

IF OBJECT_ID('ConfirmSubscription', 'P') IS NOT NULL
BEGIN
	DROP PROCEDURE ConfirmSubscription;
END

GO

CREATE PROCEDURE ConfirmSubscription
	@subscriberId int,
	@subscriptionId int
AS

	UPDATE SubscribersSubscriptions
	SET IsConfirmed = 1,
	ConfirmedDate = GETDATE()
	WHERE SubscriberId = @subscriberId
	AND SubscriptionId = @subscriptionId;