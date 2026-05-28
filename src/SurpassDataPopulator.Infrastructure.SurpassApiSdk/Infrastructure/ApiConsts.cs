namespace SurpassApiSdk.Infrastructure;

/// <summary>
/// Represents constant string values
/// </summary>
public static class ApiConsts
{
    /// <summary>
    /// Entity model names
    /// </summary>
    public static class Contracts
    {
        public const string Candidate = "candidate";
        public const string Centre = "centre";
        public const string County = "county";
        public const string Resource = "resource";
        public const string Response = "response";
        public const string Subject = "subject";
        public const string Result = "result";
        public const string TestSession = "testSession";
        public const string SummaryResult = "summaryResult";
        public const string Section = "section";
        public const string SectionSelector = "sectionSelector";
        public const string Item = "item";
        public const string LanguageVariant = "languageVariant";
        public const string ItemLanguageVariant = "itemLanguageVariant";
        public const string ItemSetLanguageVariant = "itemSetLanguageVariant";
        public const string Language = "language";
        public const string Report = "report";
        public const string User = "user";
        public const string Users = "users";
        public const string Permission = "permission";
        public const string Permissions = "permissions";
        public const string RolesTreeNode = "rolesTreeNode";
        public const string UserPermissionDetails = "userPermissionDetails";
        public const string UserPermission = "userPermission";
        public const string TestForm = "testForm";
        public const string Test = "test";
        public const string Timing = "timing";
        public const string Boundaries = "boundaries";
        public const string SectionBreak = "sectionBreak";
        public const string TestFeedbackSummaryFeedback = "testFeedbackSummaryFeedback";
        public const string GradeBoundaries = "gradeBoundaries";
        public const string TestSessionFile = "file";
        public const string CentreSubjectAssociation = "centreSubjectAssociation";
        public const string TagGroupRestrictions = "restrictions";
        public const string TagCategory = "tagCategory";
        public const string TagCollection = "tagCollection";
        public const string TagCollectionGroup = "tagCollectionGroup";
        public const string TagGroup = "tagGroup";
        public const string TagGroups = "tagGroups";
        public const string TagCategories = "tagCategories";
        public const string TagValue = "tagValue";
        public const string ItemTagValue = "itemTagValue";
        public const string Media = "media";
        public const string MediaGroup = "mediaGroup";
        public const string Folder = "folder";
        public const string ItemSet = "itemSet";
        public const string ItemOption = "itemOption";
        public const string ItemFeedback = "itemFeedback";
        public const string ItemOptionList = "itemOptionList";
        public const string AnswerList = "answerList";
        public const string BasicPage = "basicPage";
        public const string TestProfile = "testProfile";
        public const string AnalyticsResult = "analyticsResult";
        public const string HistoricalResult = "historicalResult";
        public const string QuestionResponseAuditResult = "questionResponseAuditResult";
        public const string RescoredEventHistoryResult = "rescoredEventHistoryResult";
        public const string RescoredItemHistoryResult = "rescoredItemHistoryResult";
        public const string RescoringEventResult = "rescoringEventResult";
        public const string RescoringRule = "rescoringRule";
        public const string RescoringItem = "rescoringItem";
        public const string ScaleScoreMapping = "scaleScoreMapping";
        public const string AnalyticsScaleScoreMapping = "analyticsScaleScoreMapping";
        public const string ItemResponse = "itemResponse";
        public const string CandidateInteraction = "candidateInteraction";
        public const string Interaction = "interaction";
        public const string ItemList = "itemList";
        public const string LearningOutcome = "learningOutcome";
        public const string LearningOutcomeBoundary = "learningOutcomeBoundary";
        public const string AssistiveMedia = "assistiveMedia";
        public const string ItemTool = "itemTool";
        public const string Country = "country";
        public const string CustomReportManagement = "customReportManagement";
        public const string CustomReportParam = "customReportParam";
        public const string GeneratedReport = "GeneratedReport";
        public const string Owner = "owner";
        public const string ProductToken = "productToken";
        public const string SecureClient = "secureClient";
        public const string Comment = "comment";
        public const string Group = "group";
        public const string File = "file";
        public const string IrtDomainGroup = "irtDomainGroup";
        public const string Task = "task";
        public const string TaskUser = "taskUser";
        public const string GeneralTask = "generalTask";
        public const string ItemReviewTask = "itemReviewTask";
        public const string ItemReviewResult = "itemReviewResult";
        public const string ItemReviewItemList = "itemReviewItemList";
        public const string StandardSettingItemList = "standardSettingItemList";
        public const string ReasonableAdjustments = "reasonableAdjustments";
        public const string Unit = "unit";
        public const string Metadata = "metadata";
        public const string WorkflowStatus = "workflowStatus";
        public const string ItemStatement = "itemStatement";
        public const string ItemStatementList = "itemStatementList";
        public const string LikertSelection = "selection";
        public const string Advanced = "advanced";
        public const string TestSchedule = "testSchedule";
        public const string CorrectLinks = "correctLinks";
        public const string LextBoxes = "lextBoxes";
        public const string ItemAuthoringTask = "itemAuthoringTask";
        public const string ItemAuthoringTaskStatus = "itemAuthoringTaskStatus";
        public const string ItemAuthoringItem = "itemAuthoringItem";
        public const string TaskUserDetailsResource = "taskUserDetailsResource";
        public const string Project = "project";
        public const string DownloadInfo = "information";
        public const string AdditionalMediaReplays = "additionalMediaReplays";
        public const string TaskProfile = "TaskProfile";
        public const string TaskProfileTagDetails = "TaskProfileTagDetails";
        public const string TaskProfileTagCollectionCriterion = "TaskProfileTagCollectionCriterion";
        public const string TagSummaryResource = "TagSummaryResource";
        public const string TaskAttachment = "TaskAttachment";
        public const string Settings = "settings";
        public const string DragItem = "dragItem";
        public const string DropZone = "dropZone";
        public const string StateChanges = "stateChanges";
        public const string StateChange = "stateChange";
        public const string Column = "column";
        public const string Option = "option";
        public const string Zone = "zone";
        public const string RoleCounters = "roleCounters";
        public const string NumaricaEntryQuestions = "numaricaEntryQuestions";
        public const string Answers = "answers";
        public const string Answer = "answer";
        public const string CandidateResponse = "candidateResponse";
        public const string StandardSettingTask = "standardSettingTask";
        public const string StandardSettingResult = "standardSettingResult";
        public const string RatingMethod = "ratingMethod";
        public const string RatingMethodOption = "ratingMethodOption";
        public const string TaskRatingMethod = "taskRatingMethod";
        public const string TaskRatingMethodOption = "taskRatingMethodOption";
        public const string BackgroundImage = "backgroundImage";
    }

    /// <summary>
    /// Entity property names
    /// </summary>
    public static class Members
    {
        public const string StartDate = "startDate";
        public const string EndDate = "endDate";
        public const string StartTime = "startTime";
        public const string DateCreated = "dateCreated";
        public const string EndTime = "endTime";
        public const string SavedDate = "savedDate";
        public const string AddressLine1 = "addressLine1";
        public const string AddressLine2 = "addressLine2";
        public const string Centres = "centres";
        public const string County = "county";
        public const string Counties = "counties";
        public const string Country = "country";
        public const string DateOfBirth = "dateOfBirth";
        public const string ReasonableAdjustments = "reasonableAdjustments";
        public const string BreakReasonableAdjustments = "breakReasonableAdjustments";
        public const string AddBreak = "addBreak";
        public const string AddBreakType = "addBreakType";
        public const string AddBreakPoolDuration = "addBreakPoolDuration";
        public const string EnableBreak = "enableBreak";
        public const string BreakDuration = "breakDuration";
        public const string Cancellable = "cancellable";
        public const string Email = "email";
        public const string Errors = "errors";
        public const string FirstName = "firstName";
        public const string MiddleName = "middleName";
        public const string Href = "href";
        public const string Id = "id";
        public const string Code = "code";
        public const string SurpassId = "surpassId";
        public const string ExternalId = "externalId";
        public const string LastName = "lastName";
        public const string UserName = "userName";
        public const string Gender = "gender";
        public const string Name = "name";
        public const string PostCode = "postCode";
        public const string Tel = "tеl";
        public const string Uln = "uln";
        public const string Reference = "reference";
        public const string Response = "response";
        public const string FileType = "fileType";
        public const string Report = "report";
        public const string Data = "data";
        public const string Retired = "retired";
        public const string IsExternal = "isExternal";
        public const string ReportParameters = "reportParameters";
        public const string JobTitle = "jobTitle";
        public const string DefaultLanguage = "defaultLanguage";
        public const string SsoExternalId = "ssoExternalId";
        public const string Permission = "permission";
        public const string Permissions = "permissions";
        public const string UserPermissions = "userPermissions";
        public const string UserCentreSubjectRoles = "userCentreSubjectRoles";
        public const string Role = "role";
        public const string Roles = "roles";
        public const string IsRoot = "isRoot";
        public const string NotAssignable = "notAssignable";

        public const string User = "user";
        public const string Assignable = "assignable";
        public const string AssignableStripped = "a";
        public const string MarkedExternally = "markedExternally";
        public const string AllowMultipleOpenSessions = "allowMultipleOpenSessions";
        public const string RequiresInvigilation = "requiresInvigilation";
        public const string Language = "language";
        public const string LanguageVariants = "languageVariants";
        public const string Subjects = "subjects";
        public const string Town = "town";
        public const string Values = "values";
        public const string UserCentres = "userCentres";
        public const string UserCentresSkippedCount = "userCentresSkippedCount";
        public const string DropZones = "dropZones";
        public const string AdditionalOptions = "additionalOptions";
        public const string CustomItemsPerZone = "customItemsPerZone";
        public const string DndType = "type";
        public const string MaxItemsPerZoneType = "maxItemsPerZoneType";
        public const string EqualsToCorrectOptions = "equalsToCorrectOptions";
        public const string EqualsToTotalOptions = "equalsToTotalOptions";
        public const string CustomMarks = "customMarks";
        public const string DragItem = "dragItem";
        public const string DropZone = "dropZone";
        public const string XAxis = "x";
        public const string YAxis = "y";
        public const string Width = "width";
        public const string Height = "height";
        public const string BackgroundImage = "backgroundImage";

        public const string PrevPageLink = "prevPageLink";
        public const string NextPageLink = "nextPageLink";
        public const string Top = "top";
        public const string Skip = "skip";
        public const string PageCount = "pageCount";
        public const string ServerTimeZone = "serverTimeZone";
        public const string PermanentlyDeleted = "permanentlyDeleted";

        public const string PageSize = "pageSize";
        public const string UserNameMaxLength = "userNameMaxLength";
        public const string UserNameMinLength = "userNameMinLength";
        public const string DateFormat = "dateFormat";
        public const string Languages = "languages";
        public const string HelpPages = "helpPages";
        public const string Key = "key";
        public const string Removed = "removed";
        public const string CentreLevelBaseRoleId = "centreLevelBaseRoleId";
        public const string DialogsPageSize = "dialogsPageSize";

        public const string Count = "count";
        public const string Counter = "counter";
        public const string CounterText = "counterText";
        public const string CandidateResponse = "candidateResponse";
        public const string ItemComment = "itemComment";
        public const string Test = "test";
        public const string Timing = "timing";
        public const string DateApplied = "dateApplied";
        public const string IsLatest = "isLatest";
        public const string TestForm = "testForm";
        public const string TestFormVersion = "testFormVersion";
        public const string GradeBoundaries = "gradeBoundaries";
        public const string RoundToDecimalPlaces = "roundToDecimalPlaces";
        public const string Printable = "printable";
        public const string AllowCloseWithoutSubmit = "allowCloseWithoutSubmit";
        public const string RequiresModeration = "requiresModeration";
        public const string RequiresSecureMarker = "requiresSecureMarker";
        public const string TestFeedbackPassFail = "testFeedbackPassFail";
        public const string TestFeedbackPercentageMark = "testFeedbackPercentageMark";
        public const string TestFeedbackShowFeedbackButtonDuringTest = "testFeedbackShowFeedbackButtonDuringTest";
        public const string ItemComments = "itemComments";
        public const string TestFormComments = "testFormComments";
        public const string TestFeedbackSummaryFeedback = "testFeedbackSummaryFeedback";
        public const string AdvanceContentDownloadTimespan = "advanceContentDownloadTimespan";
        public const string AllowUseAsTemplate = "allowUseAsTemplate";
        public const string MinRawScore = "minRawScore";
        public const string Centre = "centre";
        public const string PrimaryCentre = "primaryCentre";
        public const string Primary = "primary";
        public const string Subject = "subject";
        public const string SharedWith = "sharedWith";
        public const string StandardLists = "standardLists";
        public const string Keycode = "keycode";
        public const string Mark = "mark";
        public const string Marking = "marking";
        public const string NotAttempted = "notAttempted";
        public const string Citations = "citations";
        public const string AwardedMark = "awardedMark";
        public const string Notes = "notes";
        public const string Grade = "grade";
        public const string StartedDate = "startedDate";
        public const string SubmittedDate = "submittedDate";
        public const string Started = "started";
        public const string IsReview = "isReview";
        public const string WarehousedDate = "warehousedDate";
        public const string ResultsReleased = "resultsReleased";
        public const string ResultsSampled = "resultsSampled";
        public const string ScaleScore = "scaleScore";
        public const string CustomRoundingDecimalPlace = "customRoundingDecimalPlaces";
        public const string Sections = "sections";
        public const string SectionSelectors = "sectionSelectors";
        public const string AvailableMarks = "availableMarks";
        public const string PassMark = "passMark";
        public const string NumberOfItemsToMark = "numberOfItemsToMark";
        public const string UnlockSection = "unlockSection";
        public const string ForwardOnlySection = "forwardOnlySection";
        public const string AllowItemReview = "allowItemReview";
        public const string ItemsRequireResponse = "itemsRequireResponse";
        public const string SectionBreak = "sectionBreak";
        public const string Pass = "pass";
        public const string ViewingTime = "viewingTime";
        public const string Items = "items";
        public const string Projects = "projectIds";
        public const string IsMaster = "isSubjectMasterList";
        public const string Version = "version";
        public const string LearningOutcome = "learningOutcome";
        public const string Unit = "unit";
        public const string SurpassReference = "surpassReference";
        public const string Candidate = "candidate";
        public const string Voided = "voided";
        public const string Status = "status";
        public const string ReasonableAdjustmentsStandard = "reasonableAdjustmentsStandard";
        public const string ReasonableAdjustmentsMax = "reasonableAdjustmentsMax";
        public const string ExcludeFromRandomTestFormSelection = "excludeFromRandomTestFormSelection";
        public const string DeliveryType = "deliveryType";
        public const string HtmlOnly = "htmlOnly";
        public const string UseMasterList = "subjectMasterList";
        public const string TestState = "testState";
        public const string VoidReason = "voidReason";
        public const string VoidMessage = "voidMessage";
        public const string NonScored = "nonScored";
        public const string HistoricalResults = "historicalResults";
        public const string RescoringRules = "rescoringRules";
        public const string AdjustedGrade = "adjustedGrade";
        public const string ForceLocalVoid = "forceLocalVoid";
        public const string ChangeDetails = "changeDetails";
        public const string RequiredSections = "requiredSections";
        public const string SectionSelectorId = "sectionSelectorId";
        public const string MarkBreakdownItem = "markBreakdownItem";
        public const string MarkBreakdown = "markBreakdown";
        public const string DurationMode = "durationMode";
        public const string IsManuallySubmittedInLocal = "isManuallySubmittedInLocal";
        public const string Untimed = "Untimed";
        public const string Timed = "Timed";
        public const string TimedSections = "Timed Sections";
        public const string OfflineDelivery = "offlineDelivery";
        public const string Analysis = "analysis";
        public const string UnitName = "unitName";
        public const string LearnongOutcomeName = "learningOutcomeName";
        public const string CorrectCount = "correctCount";
        public const string AttemptCount = "attemptCount";
        public const string Score = "score";
        public const string ItemStatus = "itemStatus";
        public const string TaskProfile = "taskProfile";

        public const string Pin = "pin";

        public const string RandomiseTestForms = "randomiseTestForms";
        public const string HideSubjectFromSubjectGroups = "hideSubjectsIncludedInSubjectGroups";
        public const string ExcludeItemStatistics = "excludeItemStatistics";

        public const string Generate = "generate";

        public const string ExtraTimePercentage = "extraTimePercentage";
        public const string ExtraTimeMinutes = "extraTimeMin";
        public const string Reason = "reason";

        public const string RecordId = "recordId";
        public const string RecordIdStripped = "r";
        public const string CentreId = "centreId";
        public const string CentreIdStripped = "c";
        public const string SubjectId = "subjectId";
        public const string SubjectIdStripped = "s";
        public const string IsSecureClient = "isSecureClient";
        public const string IsSecureClientStripped = "sc";
        public const string TagGroup = "tagGroup";
        public const string TagTypeName = "tagTypeName";
        public const string CollectionGroup = "collectionGroup";
        public const string Collection = "collection";
        public const string SubCollection = "subCollection";
        public const string IsCurrent = "isCurrent";
        public const string TagGroups = "tagGroups";
        public const string TagGroupNames = "tagGroupNames";
        public const string TagCategories = "tagCategories";
        public const string SubCollections = "subCollections";
        public const string TagValue = "tagValue";
        public const string TagCollections = "tagCollections";
        public const string TestTag = "tag";
        public const string TestTags = "testTags";
        public const string DataField = "dataField";
        public const string Caption = "caption";
        public const string Item = "item";
        public const string Deleted = "deleted";
        public const string AllowRandomisation = "allowRandomisation";
        public const string AllowMultipleTags = "allowMultipleTags";
        public const string ReadonlyTagGroup = "isReadOnly";
        public const string IsCollectable = "isCollectable";
        public const string IsPublishable = "isPublishable";
        public const string AuthorCreation = "authorCreation";
        public const string NumericTagProperties = "numericTagProperties";
        public const string TagTypeValue = "tagTypeValue";
        public const string TagGroupRestrictions = "restrictions";
        public const string TagGroupRestrictionsType = "type";
        public const string LowerBoundary = "lowerBoundary";
        public const string UpperBoundary = "upperBoundary";
        public const string Boundary = "boundary";
        public const string TagGroupRestrictionsAllowDecimalPlaces = "allowDecimalPlaces";
        public const string ParentFolderId = "parentFolderId";
        public const string Position = "position";
        public const string SubjectItemTagValue = "subjectItemTagValue";
        public const string SubjectItemTagValues = "itemTagValues";
        public const string SubjectItemSetTagValues = "itemSetTagValues";
        public const string QuestionText = "questionText";
        public const string HtmlText = "htmlText";
        public const string Folder = "folder";
        public const string ItemSet = "itemSet";
        public const string SeedUsageCount = "seedUsageCount";
        public const string SeedPValue = "seedPValue";
        public const string ItemPurpose = "itemPurpose";
        public const string MarkingType = "markingType";
        public const string Randomise = "randomise";
        public const string AddLabelsToOptions = "addLabelsToOptions";
        public const string GeneralFeedback = "generalFeedback";
        public const string CorrectFeedback = "correctFeedback";
        public const string IncorrectFeedback = "incorrectFeedback";
        public const string MediaItems = "mediaItems";
        public const string SourceMaterials = "sourceMaterials";
        public const string StemComponents = "stemComponents";
        public const string Options = "options";
        public const string OptionsList = "optionLists";
        public const string DragOptions = "dragOptions";
        public const string CorrectDragOptions = "correctDragOptions";
        public const string Text = "text";
        public const string Correct = "correct";
        public const string Label = "label";
        public const string MediaItem = "mediaItem";
        public const string StemMedia = "stemMedia";
        public const string Media = "media";
        public const string OptionList = "optionList";
        public const string IsChangableNumberOfOptions = "isChangableNumberOfOptions";
        public const string MinNumberOfOptions = "minNumberOfOptions";
        public const string NumberOfOptions = "numberOfOptions";
        public const string AnswersType = "answersType";
        public const string ContentType = "contentType";
        public const string MathMl = "mathMl";
        public const string AssistiveMedia = "assistiveMedia";
        public const string WithDeleteLink = "withDeleteLink";
        public const string ValidateAnswerOptions = "validateAnswerOptions";
        public const string MultipleChoiceQuestions = "multipleChoiceQuestions";
        public const string DragAndDropQuestions = "dragAndDropQuestions";
        public const string MultipleResponseQuestions = "multipleResponseQuestions";
        public const string DragDropQuestions = "dragDropQuestions";
        public const string PartialMarks = "partialMarks";
        public const string MaxSelections = "maxSelections";
        public const string MinSelections = "minSelections";
        public const string MarkScheme = "markScheme";
        public const string MarkingSchemeFileId = "markingSchemeFileId";
        public const string MarkingSchemeFileName = "markingSchemeFileName";
        public const string EnableTextFormatting = "enableTextFormatting";
        public const string ExclusiveOptionEnabled = "exclusiveOptionEnabled";
        public const string MaxCharacters = "maxCharacters";
        public const string NumberOfLines = "numberOfLines";
        public const string DisplayCounter = "displayCounter";
        public const string NumberOfLinesPerResponse = "numberOfLinesPerResponse";
        public const string WordCounterLabel = "wordCounterLabel";
        public const string TextDirectionMode = "textDirectionMode";
        public const string PurchaseOrder = "purchaseOrder";
        public const string AnswerColumns = "answerColumns";
        public const string AnswerWidthRatio = "answerWidthRatio";
        public const string TableOptionsHtml = "tableOptionsHtml";
        public const string ChildrenLocked = "locked";

        public const string EssayQuestions = "essayQuestions";
        public const string ShortAnswerQuestions = "shortAnswerQuestions";
        public const string RequireCaseSensitive = "requireCaseSensitive";
        public const string LimitCandidateResponse = "limitCandidateResponse";
        public const string MaxCharacterCount = "maxCharacterCount";
        public const string TimeLength = "timeLength";
        public const string AnswerList = "answerList";
        public const string Answers = "answers";
        public const string AdditionalHtmlText = "additionalHtmlText";
        public const string Type = "type";
        public const string AreaType = "areaType";
        public const string AdditionalMathMl = "additionalMathMl";
        public const string AdditionalContentType = "additionalContentType";
        public const string AllowOpenImageInPopup = "allowOpenImageInPopup";
        public const string MediaLayout = "mediaLayout";

        public const string IsPublished = "published";
        public const string WindowPosition = "windowPosition";
        public const string ImageUrl = "imageURL";
        public const string Image = "image";
        public const string WarningIntervals = "warningIntervals";
        public const string WarningDuration = "warningDuration";
        public const string ShowAlertsInFrontOfAllWindows = "showAlertsInFrontOfAllWindows";

        public const string ProviderLogoColor = "providerLogocolor";
        public const string ProviderLogoMonochrome = "providerLogoMono";
        public const string ClientLogoColor = "clientLogocolor";
        public const string ClientLogoMonochrome = "clientLogoMono";

        public const string ProfileName = "profileName";
        public const string ColourBackground = "ColourBackground";
        public const string ColourText = "ColourText";
        public const string HeaderFooter = "headerFooterColours";
        public const string FinishButton = "finishButtonColours";
        public const string PrimaryButton = "primaryButtonColours";
        public const string SecondaryButton = "secondaryButtonColours";

        public const string SelectAll = "All";
        public const string CandidateFirstNameEnable = "candidateFirstNameEnable";
        public const string CandidateLastNameEnable = "candidateLastNameEnable";
        public const string CandidateDateOfBirthEnable = "candidateDateOfBirthEnable";
        public const string CandidateGenderEnable = "candidateGenderEnable";
        public const string CandidateReferenceEnable = "candidateReferenceEnable";

        public const string FileUrl = "fileUrl";
        public const string TempFilePath = "tempFilePath";

        public const string IsDefault = "isDefault";
        public const string Settings = "settings";
        public const string ProviderLogo = "providerLogo";
        public const string ClientLogo = "clientLogo";
        public const string Logo = "logo";
        public const string Colours = "colours";
        public const string CandidateDetails = "candidateDetails";
        public const string ScoreReportTemplate = "scoreReportTemplate";
        public const string Manifest = "manifest";
        public const string SupportingInfo = "supportingInfo";
        public const string ContentManifestFile = "contentManifestFile";
        public const string SupportingInfoFile = "supportingInfoFile";
        public const string ScoreReportHtml = "scoreReportHtml";
        public const string ImageId = "imageId";
        public const string ImageName = "imageName";
        public const string TempImagePath = "tempImagePath";
        public const string Color = "color";
        public const string Monochrome = "monochrome";
        public const string FileName = "fileName";
        public const string FilePath = "filePath";
        public const string FileId = "fileId";
        public const string FileSize = "fileSize";
        public const string TaskId = "taskId";

        public const string MarkType = "markType";
        public const string WeightedMark = "weightedMark";
        public const string Title = "title";
        public const string Combinations = "combinations";

        public const string ItemIds = "itemIds";
        public const string Introduction = "introduction";
        public const string Section = "section";
        public const string SectionType = "type";
        public const string Tools = "tools";
        public const string Owner = "owner";
        public const string Finish = "finish";
        public const string CertifiedAccessible = "certifiedAccessible";
        public const string UseAsTemplate = "useAsTemplate";
        public const string ExamType = "ExamType";
        public const string AllowTimeExtensionWhileInProgress = "allowTimeExtensionWhileInProgress";
        public const string AttemptAutoSubmit = "attemptAutoSubmit";
        public const string ResultsUploadGracePeriod = "resultsUploadGracePeriod";
        public const string RequiresSecureClient = "requiresSecureClient";
        public const string RequiresBYODMode = "requiresBYODMode";
        public const string SecureClientMode = "secureClientMode";
        public const string CertifiedForTabletDelivery = "certifiedForTabletDelivery";
        public const string Required = "required";
        public const string Duration = "duration";
        public const string TestDuration = "testDuration";
        public const string IrtRangeLower = "irtRangeLower";
        public const string IrtRangeHigher = "irtRangeHigher";
        public const string ConfirmationText = "confirmationText";
        public const string NDA = "NDA";
        public const string NumberOfResits = "numberOfResits";
        public const string ValidFromDate = "validFromDate";
        public const string ValidToDate = "validToDate";
        public const string ExpiryDate = "expiryDate";
        public const string TestWindowStartTime = "testWindowStartTime";
        public const string TestWindowEndTime = "testWindowEndTime";
        public const string AllowTestFormRecycling = "allowTestFormRecycling";
        public const string DeliveryOptions = "deliveryOptions";
        public const string TestDistribution = "testDistribution";
        public const string Mode = "mode";
        public const string TestProfile = "testProfile";
        public const string DisplayReport = "displayReport";
        public const string DisplayReportPrintButton = "displayReportPrintButton";
        public const string ShowPageButton = "showPageButton";
        public const string StyleProfile = "styleProfile";
        public const string DefaultNavigationLanguage = "defaultNavigationLanguage";
        public const string AllowLanguageOverride = "allowLanguageOverride";
        public const string ShowPageRequiresScrollingAlert = "showPageRequiresScrollingAlert";
        public const string EasyPvalue = "easyPvalue";
        public const string MaxEasyPvalue = "maxEasyPvalue";
        public const string HardPvalue = "hardPvalue";
        public const string MinHardPvalue = "minHardPvalue";
        public const string MinimumResitTime = "minimumResitTime";
        public const string GenerateTestStatistics = "generateTestStatistics";
        public const string AllowPackagingOfCandidateResponses = "allowPackagingOfCandidateResponses";
        public const string AutomaticallyShowToCentre = "automaticallyShowToCentre";
        public const string AutoCreatePIN = "autoCreatePIN";
        public const string StrictControlReasonableAdjustments = "strictControlReasonableAdjustments";
        public const string EnableCandidateLogging = "enableCandidateLogging";
        public const string Modifer = "modifer";
        public const string Value = "value";
        public const string MediaId = "mediaId";
        public const string MediaName = "mediaName";
        public const string ReviewAnswers = "reviewAnswers";
        public const string PrintableSummary = "printableSummary";
        public const string ShowCandidateDetails = "showCandidateDetails";
        public const string DisplayFeedbackByLearningOutcome = "displayFeedbackByLearningOutcome";
        public const string ShowViewFeedbackButton = "showViewFeedbackButton";
        public const string Description = "description";
        public const string RandomiseItems = "randomiseItems";
        public const string HigherBoundary = "higherBoundary";
        public const string Boundaries = "boundaries";
        public const string ScoreBoundaries = "scoreBoundaries";
        public const string ProgressBar = "progressBar";
        public const string TestStyle = "testStyle";
        public const string EitherOrQuestions = "eitherOrQuestions";
        public const string TagTypeKey = "tagTypeKey";
        public const string AuthorValuesAllowed = "authorValuesAllowed";
        public const string Range = "range";
        public const string AnswerRange = "answerRange";
        public const string MultipleValuesAllowed = "multipleValuesAllowed";
        public const string MinValue = "minValue";
        public const string MaxValue = "maxValue";
        public const string DecimalSeparator = "decimalSeparator";
        public const string NumericalEntryQuestions = "numericalEntryQuestions";
        public const string SpecificValue = "specificValue";
        public const string OrderOptionsAlphabetically = "orderOptionsAlphabetically";
        public const string OrderNumber = "orderNumber";
        public const string PlaceholderText = "placeholderText";
        public const string AwardAllCorrect = "awardAllCorrect";
        public const string Placeholders = "placeholders";
        public const string PlaceholderOptions = "placeholderOptions";
        public const string IsCorrect = "isCorrect";
        public const string CorrectAnswer = "correctAnswer";
        public const string CorrectAnswers = "correctAnswers";
        public const string UnassignedDragOptions = "unassignedDragOptions";
        public const string MaxOptions = "maxOptions";
        public const string DropZoneId = "dropZoneId";
        public const string DragOptionId = "dragOptionId";
        public const string FillInTheBlankQuestions = "fillInTheBlankQuestions";
        public const string SelectFromAListQuestions = "selectFromAListQuestions";
        public const string VoiceCaptureQuestions = "voiceCaptureQuestions";
        public const string LikertQuestions = "likertQuestions";
        public const string ItemMajorVersion = "itemMajorVersion";
        public const string ItemVersion = "itemVersion";
        public const string PublishId = "publishId";
        public const string PublishStatus = "publishStatus";
        public const string RescoredItems = "rescoredItems";
        public const string RescoredItem = "rescoredItem";
        public const string ScoringData = "scoringData";
        public const string ScoringDataItem = "scoringDataItem";
        public const string ChangeAction = "changeAction";
        public const string ItemId = "itemId";
        public const string UnattemptedMark = "unattemptedMark";
        public const string AnswerOptions = "answerOptions";
        public const string TotalMark = "totalMark";
        public const string DisplayLabel = "displayLabel";
        public const string OriginalMark = "originalMark";
        public const string NewMark = "newMark";
        public const string OriginalItemMarkType = "originalItemMarkType";
        public const string OriginalOnlyAwardIfAllCorrect = "originalOnlyAwardIfAllCorrect";
        public const string NewOnlyAwardIfAllCorrect = "newOnlyAwardIfAllCorrect";
        public const string ScaleScoreMapping = "scaleScoreMapping";
        public const string RawScore = "rawScore";
        public const string ScaleScoreId = "scaleScoreId";
        public const string ScaleScores = "scaleScores";
        public const string AnalyticScaleScores = "mappings";
        public const string TestFormId = "testFormId";
        public const string PassMarkType = "passMarkType";
        public const string PassPercentage = "passPercentage";
        public const string PercentageMark = "percentageMark";
        public const string ItemResponse = "itemResponse";
        public const string Selected = "selected";
        public const string UserMark = "userMark";
        public const string Weighting = "weighting";
        public const string ExamCostCode = "examCostCode";
        public const string NumberOfExtraBreaksPerSection = "numberOfExtraBreaksPerSection";
        public const string UnsupportedQuestionTypes = "unsupportedQuestionTypes";
        public const string Attempted = "attempted";
        public const string Time = "time";
        public const string Interactions = "interactions";
        public const string ClientInformation = "clientInformation";
        public const string CreatedBy = "createdBy";
        public const string Publishable = "publishable";
        public const string IsDeleted = "isDeleted";
        public const string AlgorithmResponseData = "algorithmResponseData";
        public const string IsPoolTimeSection = "isPoolTimeSection";
        public const string IsSurveySection = "isSurveySection";
        public const string PoolName = "poolName";
        public const string Marker = "marker";
        public const string ResponseString = "responseString";

        public const string ThresholdExceeded = "thresholdExceeded";
        public const string DefaultPassMarkApplied = "defaultPassMarkApplied";
        public const string LearningOutcomeBoundariesApplied = "learningOutcomeBoundariesApplied";
        public const string LearningOutcomeThreshold = "learningOutcomeThreshold";
        public const string LearningOutcomes = "learningOutcomes";
        public const string LearningOutcomeBoundaries = "learningOutcomeBoundaries";
        public const string LoBoundaries = "loBoundaries";
        public const string ItemType = "itemType";
        public const string SharedResource = "sharedResource";
        public const string HtmlString = "htmlString";

        public const string EnemyItems = "enemyItems";
        public const string SecondaryEnemyItems = "secondaryEnemyItems";
        public const string SectionEnemyItems = "sectionEnemyItems";
        public const string SectionSecondaryEnemyItems = "secondarySectionEnemyItems";

        public const string EnforceTimes = "enforceTimes";

        public const string SectionStartTime = "startTime";
        public const string SectionEndTime = "endTime";
        public const string UnscheduledBreak = "unscheduledBreak";
        public const string ExtraTimeMin = "extraTimeMin";
        public const string Token = "token";
        public const string HasAccess = "hasAccess";
        public const string ItemPackage = "itemPackage";
        public const string UserAssociations = "userAssociations";
        public const string RestrictUserAccess = "restrictUserAccess";
        public const string EnableMarker = "enableMarker";
        public const string RequireMarker = "requireMarker";
        public const string EnableModerator = "enableModerator";
        public const string RequireModerator = "requireModerator";
        public const string LocalState = "localState";
        public const string UploadResponses = "uploadResponses";
        public const string ExternalReference = "externalReference";
        public const string TestActivatedInfo = "testActivatedInfo";
        public const string Private = "private";
        public const string PrivateComment = "commentIsPrivate";
        public const string IsMultipleChange = "isMultipleChange";
        public const string Comment = "comment";
        public const string FileAttachQuestions = "fileAttachQuestions";
        public const string Content = "content";
        public const string Files = "files";
        public const string Comments = "comments";
        public const string Group = "group";
        public const string FileExtension = "fileExtension";
        public const string QuestionNumber = "questionNumber";
        public const string Answer = "answer";
        public const string IsSuccess = "isSuccess";
        public const string Message = "message";
        public const string Number = "number";
        public const string GroupMediaId = "groupMediaId";
        public const string QualityReview = "qualityReview";

        public const string DeliveryPresentation = "deliveryPresentation";
        public const string FinishButtonShown = "finishButtonShown";
        public const string SectionReviewButtonShown = "sectionReviewButtonShown";
        public const string FlagButtonShown = "flagButtonShown";
        public const string PreferencesButtonShown = "preferencesButtonShown";
        public const string QuestionTitleDisplayMode = "questionTitleDisplayMode";
        public const string SectionInformationShown = "SectionInformationShown";
        public const string ItemSetNumberingEnabled = "ItemSetNumberingEnabled";
        public const string ItemSetHeaderShown = "ItemSetHeaderShown";
        public const string TextForItemSetName = "TextForItemSetName";
        public const string TextForItemName = "TextForItemName";

        public const string CandidateReview = "candidateReview";
        public const string CorrectItemsEnable = "correctItemsEnable";
        public const string IncorrectItemsEnable = "incorrectItemsEnable";
        public const string UnattemptedItemsEnable = "unattemptedItemsEnable";
        public const string CandidateResponseEnable = "candidateResponseEnable";
        public const string CorrectAnswersEnable = "correctAnswersEnable";
        public const string CandidateFeedbackEnable = "candidateFeedbackEnable";

        public const string IrtTheta = "IRTScore";
        public const string PassIrt = "passIRTScore";
        public const string IrtDomain = "IRTDomain";
        public const string IrtScore = "IRTScore";

        public const string TaskType = "type";
        public const string TaskStatus = "status";
        public const string Manager = "manager";
        public const string CreateDate = "createDate";
        public const string UpdateDate = "updateDate";
        public const string Creator = "creator";
        public const string Users = "users";
        public const string TaskManager = "manager";
        public const string TaskExecutor = "executor";
        public const string TaskExecutors = "executors";
        public const string ItemList = "itemList";
        public const string ExternalItemId = "externalItemId";
        public const string ExternalItemParentId = "externalItemParentId";
        public const string ExternalItemVersion = "externalItemVersion";
        public const string ExternalSubjectId = "externalSubjectId";
        public const string ExternalItemListId = "externalItemListId";
        public const string ReviewResult = "reviewResult";
        public const string ResultComment = "comment";
        public const string ResultLastModifiedDate = "lastModifiedDate";
        public const string Task = "task";
        public const string TaskUser = "taskUser";
        public const string AllowEditItems = "allowEditItems";
        public const string AllowEditItemsByLeadAssignee = "allowEditItemsByLeadAssignee";
        public const string RefreshListContent = "refreshListContent";
        public const string IsFinalDecision = "isFinalDecision";
        public const string WorkFlowStatusId = "workFlowStatusId";
        public const string IsFlagged = "isFlagged";
        public const string IsSubmitted = "isSubmitted";
        public const string CommentDate = "commentDate";
        public const string AlternativeOptions = "alternativeOptions";
        public const string DeleteRecommendation = "deleteRecommendation";
        public const string HasTrackedChanges = "hasTrackedChanges";
        public const string IsChangesTrackingEnabled = "isChangesTrackingEnabled";
        public const string OverrideUserLock = "overrideUserLock";
        public const string ItemAuthoringTaskId = "itemAuthoringTaskId";
        public const string ItemSource = "itemSource";
        public const string TaskSubjectId = "taskSubjectId";
        public const string ItemAuthoringItems = "itemAuthoringItems";
        public const string UserId = "userId";
        public const string State = "state";
        public const string ReviewType = "reviewType";
        public const string ParentId = "parentId";
        public const string IsContainer = "isContainer";
        public const string TaskUserRole = "role";
        public const string LeadAssignee = "leadAssignee";
        public const string IsExtendedHistoryEnabled = "isExtendedHistoryEnabled";
        public const string TaskAttachments = "attachments";
        public const string NavigationType = "navigationType";
        public const string RatingMethods = "ratingMethods";
        public const string RatingMethod = "ratingMethod";
        public const string RatingMethodOptions = "ratingMethodOptions";
        public const string RatingMethodOption = "ratingMethodOption";
        public const string RatingMethodResults = "ratingMethodResults";
        public const string IsLastViewed = "isLastViewed";
        public const string IsPartiallySubmitted = "isPartiallySubmitted";
        public const string SuccessorFromItemId = "successorFromItemId";

        public const string CustomReport = "report";
        public const string CustomReportEntityKey = "entity";
        public const string CustomReportEntityValues = "values";
        public const string CustomReportEntities = "entities";
        public const string CustomReportTemplatingEngine = "templatingEngine";
        public const string CustomReportParameters = "parameters";
        public const string CustomReportCustomData = "customData";
        public const string CustomReportTemplate = "templateFile";
        public const string CustomReportCreationDate = "creationDate";
        public const string CustomReportTemplatePath = "path";
        public const string CustomReportTemplateUrl = "url";
        public const string CustomReportHtml = "html";
        public const string CustomReportClaimsIsSiteAdministrator = "isSiteAdministrator";
        public const string CustomReportClaimsCanViewReports = "canViewReports";
        public const string CustomReportClaimsCanManageCustomReports = "canManageCustomReports";
        public const string CustomReportClaimsCanGenerateCustomReports = "canGenerateCustomReports";

        public const string DecisionPoint = "decisionPoint";
        public const string UpperValue = "upperValue";
        public const string LowerValue = "lowerValue";
        public const string SectionsToCheck = "sectionsToCheck";
        public const string ValueType = "valueType";
        public const string Outcome = "outcome";
        public const string CutScoreAvailableMarks = "cutScoreAvailableMarks";
        public const string AdditionalMediaReplays = "additionalMediaReplays";

        public const string ExamWindowStartTime = "examWindowStartTime";
        public const string AllowedDuration = "allowedDuration";
        public const string TotalTimeAdded = "totalTimeAdded";
        public const string ReasonForAdjustment = "reasonForAdjustment";
        public const string Remark = "re-mark";
        public const string ActualDuration = "actualDuration";
        public const string Metadata = "metadata";
        public const string EmbedLink = "embedLink";
        public const string RationaleEnabled = "rationaleEnabled";
        public const string RationaleText = "rationaleText";
        public const string AwaitingMarkingSubmission = "awaitingMarkingSubmission";
        public const string MarkingProgressPercent = "markingProgressPercent";
        public const string RequiresExtraInfo = "requiresExtraInfo";
        public const string ExtraInfo = "extraInfo";
        public const string ExtraInfoLabel = "extraInfoLabel";
        public const string ExclusiveOption = "exclusiveOption";
        public const string IsMatrixMode = "isMatrixMode";
        public const string StatementList = "statementList";
        public const string Statements = "statements";
        public const string Selections = "selections";
        public const string StatementId = "statementId";
        public const string OptionId = "optionId";
        public const string Advanced = "advanced";
        public const string SharedAnswers = "sharedAnswers";
        public const string ExtendedMatchingQuestions = "extendedMatchingQuestions";
        public const string HotSpotQuestions = "hotSpotQuestions";
        public const string Coordinates = "co-ordinates";
        public const string MatchingBoxesType = "linkingType";
        public const string WeightedMarking = "weightedMarking";
        public const string LeftBoxes = "leftBoxes";
        public const string RightBoxes = "rightBoxes";
        public const string Links = "correctLinks";
        public const string LinkType = "linkingType";
        public const string IsEnableManyToManyMarking = "enableManyToManyMarking";
        public const string LeftBoxId = "leftBoxId";
        public const string RightBoxId = "rightBoxId";
        public const string ItemSetId = "itemSetId";
        public const string ItemSetName = "itemSetName";
        public const string DisplayNumber = "displayNumber";
        public const string IsManualMode = "isManualMode";
        public const string DownloadWording = "downloadWording";
        public const string CurrentExamState = "currentExamState";
        public const string Valid = "valid";
        public const string UploadWording = "uploadWording";
        public const string ChooseFileButtonWording = "chooseFileButtonWording";
        public const string AllowedExtensions = "allowedExtensions";
        public const string UnlockForWholeDay = "unlockForWholeDay";
        public const string DaysInAdvanceToUnlock = "daysInAdvanceToUnlock";
        public const string DaysAfterToLock = "daysAfterToLock";
        public const string UnlockOverride = "unlockOverride";
        public const string ForceRequireExamVersionDate = "forceRequireExamVersionDate";
        public const string AttachedFileType = "attachedFileType";
        public const string AttachedFileName = "attachedFileName";
        public const string AttachedFileData = "attachedFileData";
        public const string IsSecureDoc = "isSecureDoc";
        public const string UploadLabel = "uploadLabel";
        public const string AttachmentType = "attachmentType";
        public const string MinimumNumberOfFiles = "minimumNumberOfFiles";
        public const string MaximumNumberOfFiles = "maximumNumberOfFiles";
        public const string MaximumFileSize = "maximumFileSize";
        public const string OwnerId = "ownerId";
        public const string OwnerName = "ownerName";
        public const string ItemsCount = "itemsCount";
        public const string DownloadedToSecureClient = "downloadedToSecureClient";
        public const string Downloads = "downloads";
        public const string TotalCount = "totalCount";
        public const string OS = "os";
        public const string IPAddress = "ipAddress";
        public const string MachineName = "machineName";
        public const string DateTime = "dateTime";
        public const string Local = "local";
        public const string CreationDate = "creationDate";
        public const string SelectedSections = "selectedSections";
        public const string SectionName = "sectionName";
        public const string SectionOrder = "sectionOrder";
        public const string CanExportToWord = "canExportToWord";
        public const string RequiresCheckIn = "requiresCheckIn";
        public const string TestSessionFiles = "files";
        public const string TestSessionId = "testSessionId";
        public const string TestSessionName = "name";
        public const string TestSessionDescription = "description";
        public const string TestSessionData = "data";

        public const string TagsVisibilityType = "tagsVisibilityType";
        public const string TagCollectionsVisibilityType = "tagCollectionsVisibilityType";
        public const string TaskProfileTagDetails = "taskProfileTagDetails";
        public const string TagCollectionCriteria = "tagCollectionCriteria";
        public const string SubjectReferences = "subjectReferences";
        public const string TagCollectionGroup = "tagCollectionGroup";
        public const string TagCollectionGroupId = "tagCollectionGroupId";
        public const string InverseTagCollectionSelection = "inverseTagCollectionSelection";

        public const string CategoryName = "categoryName";
        public const string GroupName = "groupName";
        public const string CategoryId = "categoryId";
        public const string GroupId = "groupId";

        public const string SetupAllowCreate = "allowCreate";
        public const string SetupCanEditSiteLevelRoles = "canEditSiteLevelRoles";
        public const string SetupCanEditCentreLevelRoles = "canEditCentreLevelRoles";
        public const string SetupCanEditRoles = "canEditRoles";
        public const string SetupCanEditSecureClientRoles = "canEditSecureClientRoles";
        public const string IsSiteAdmin = "isSiteAdmin";
        public const string Disabled = "disabled";
        public const string SetupCanViewHelpContent = "canViewHelpContent";
        public const string CanEditAllSharedCentresRoles = "canEditAllSharedCentresRoles";

        public const string ExtendedDemographics = "extendedDemographics";
        public const string StateChanges = "stateChanges";
        public const string OldValue = "oldValue";
        public const string NewValue = "newValue";
        public const string Columns = "columns";
        public const string ExternalUserReference = "externalUserReference";
        public const string NewState = "newState";
        public const string Date = "date";
        public const string IsWholeScriptMarkingOn = "isWholeScriptMarkingOn";
        public const string SourceMaterialBrowserNavigationShown = "sourceMaterialBrowserNavigationShown";
        public const string EnableCheckboxesInItemAuthoring = "enableCheckboxesInItemAuthoring";
        public const string EnableCheckboxesInDelivery = "enableCheckboxesInDelivery";
        public const string AllowSourceMaterialClose = "allowSourceMaterialClose";

        public const string HasSubCollections = "hasSubCollections";
        public const string TagGroupId = "tagGroupId";
        public const string Order = "order";

        public const string UserLanguage = "userLanguage";

        public static class Tbs
        {
            public const string Questions = "tbsQuestions";
            public const string RubricXml = "rubricXml";
            public const string MeasurementOpportunityId = "guid";
            public const string ItemContent = "itemContent";
            public const string MoList = "moList";
            public const string Ids = "tbsIds";
        }

        public static class UiUsersPermissions
        {
            public const string AllowEdit = "allowEdit";
            public const string AllowEditDetails = "allowEditDetails";
            public const string AllowResetPassword = "allowResetPassword";
            public const string AllowEditRoles = "allowEditRoles";
            public const string AllowDelete = "allowDelete";
        }

        public static class RoleCounters
        {
            public const string CentreLevelCounter = "centreLevel";
            public const string SubjectLevelCounter = "subjectLevel";
            public const string SecureClientCounter = "secureClient";
        }

        public static class ScannedItemResponse
        {
            public const string ItemImagePath = "imagePath";
            public const string IsCoverSheet = "isCoverSheet";
            public const string Order = "order";
            public const string ItemIDs = "itemIDs";
        }
    }

    /// <summary>
    /// Controller names
    /// </summary>
    public static class Segments
    {
        public const string Candidate = "Candidate";
        public const string Centre = "Centre";
        public const string TestScheduleV2 = "TestSchedule";
        public const string TestSession = "TestSession";
        public const string TestSessionFile = "File";
        public const string Result = "Result";
        public const string SummaryResult = "SummaryResult";
        public const string Report = "Report";
        public const string Token = "Token";
        public const string TestForm = "TestForm";
        public const string User = "User";
        public const string Subject = "Subject";
        public const string PermissionType = "PermissionType";
        public const string CentreSubjectAssociation = "CentreSubjectAssociation";
        public const string Permission = "Permission";
        public const string UserPermission = "UserPermission";
        public const string AnalyticsResult = "AnalyticsResult";
        public const string AnalyticsScaleScoreMapping = "AnalyticsScaleScoreMapping";
        public const string HistoricalResult = "HistoricalResult";
        public const string QuestionResponseAuditResult = "QuestionResponseAuditResult";
        public const string RescoringRule = "RescoringRule";
        public const string County = "County";

        public const string TagGroup = "TagGroup";
        public const string TagValue = "TagValue";
        public const string TagCategory = "TagCategory";
        public const string TagCollectionGroup = "TagCollectionGroup";
        public const string Media = "Media";
        public const string MediaGroup = "MediaGroup";
        public const string ItemTagValue = "ItemTagValue";
        public const string Folder = "Folder";
        public const string Item = "Item";
        public const string LanguageVariant = "LanguageVariant";
        public const string ItemSetLanguageVariant = "ItemSetLanguageVariant";
        public const string ItemSet = "ItemSet";
        public const string BasicPage = "BasicPage";
        public const string TestProfile = "TestProfile";
        public const string Test = "Test";
        public const string ScaleScoreMapping = "ScaleScoreMapping";
        public const string ItemResponse = "ItemResponse";
        public const string CandidateInteractions = "CandidateInteractions";
        public const string ClientInformation = "ClientInformation";
        public const string ItemList = "ItemList";
        public const string AssistiveMedia = "AssistiveMedia";
        public const string ItemTool = "ItemToolType";

        public const string Country = "Country";
        public const string CustomReport = "CustomReport";
        public const string CustomReportGeneration = "CustomReportGeneration";

        public const string Task = "Task";
        public const string TaskAttachment = "TaskAttachment";
        public const string Attachment = "Attachment";
        public const string GeneralTask = "GeneralTask";
        public const string ItemReviewTask = "ItemReviewTask";
        public const string ItemReviewResult = "ItemReviewTask/ItemReviewResult";
        public const string ItemAuthoringTask = "ItemAuthoringTask";
        public const string ItemAuthoringResult = "ItemAuthoringTask/ItemAuthoringResult";
        public const string StandardSettingTask = "StandardSettingTask";
        public const string StandardSettingResult = "StandardSettingTask/StandardSettingResult";

        public const string WorkflowStatus = "WorkflowStatus";

        public const string TaskProfile = "TaskProfile";
        public const string TaskProfileTagDetails = "TaskProfileTagDetails";

        public const string StateChanges = "StateChanges";
    }

    /// <summary>
    /// Api method names
    /// </summary>
    public static class Methods
    {
        public const string Get = "GET";
        public const string GetWithId = "GET/{id}";
        public const string GetWithReference = "GET/{reference}";
        public const string GetWithKeycode = "GET/{keycode}";
        public const string Post = "POST";
        public const string Put = "PUT";
        public const string PutWithKeycod = "PUT/{keycode}";
        public const string PutWithId = "PUT/{id}";
        public const string Delete = "DELETE";
        public const string DeleteWithId = "DELETE/{id}";
        public const string DeleteWithKeycode = "DELETE/{keycode}";
        public const string GetManyItemResponsesForId = "GET/{id}/ ItemResponse/";
        public const string GetManyItemResponsesForKeycode = "GET/{keycode}/ ItemResponse/";
        public const string GetItemWithIdAndPageId = "GET/{id}/ ItemResponse/ {surpassReference}";
        public const string GetItemWithKeycodeAndPageId = "GET/{keycode}/ ItemResponse/ {surpassReference}";
        public const string GetCandidateInteractionWithId = "GET/{id}/ CandidateInteractions";
        public const string GetCandidateInteractionWithKeycode = "GET/{keycode}/ CandidateInteractions";
        public const string GetClientInformationWithId = "GET/{id}/ ClientInformation/";
        public const string GetClientInformationWithKeycode = "GET/{keycode}/ ClientInformation/";
        public const string GetItemAssistiveMediaWithId = "GET/{itemId}/ AssistiveMedia/{id}";
        public const string GetItemReviewTaskResults = "GET/ItemReviewTask/ ItemReviewResult";
        public const string GetItemReviewTaskResult = "GET/ItemReviewTask/ ItemReviewResult/{id}";
        public const string PutItemAssistiveMediaWithId = "PUT/{itemId}/ AssistiveMedia/{id}";
        public const string PostWithKeycodeAndMarks = "POST/{keycode}/ ItemMarks";
        public const string PostItemResponsesWithKeycode = "POST/{keycode}/ ItemResponses";
        public const string GetGeneralTask = "GET/GeneralTask/{id}";
        public const string GetItemReviewTask = "GET/ItemReviewTask/ {id}";
        public const string GetItemAuthoringTask = "GET/ ItemAuthoringTask/{id}";
        public const string GetStandardSettingTask = "GET/ StandardSettingTask/ {id}";
        public const string GetStandardSettingResults = "GET/ StandardSettingTask/ StandardSettingResult";
        public const string GetStandardSettingResult = "GET/ StandardSettingTask/ StandardSettingResult/ {id}";
        public const string GetItemReviewTaskAttachment = "GET/ ItemReviewTask/ {taskId}/ Attachment/{id}";
        public const string GetItemAuthoringTaskAttachment = "GET/ ItemAuthoringTask/ {taskId}/ Attachment/{id}";

        public const string GetStandardSettingTaskAttachment =
            "GET/ StandardSettingTask/ {taskId}/ Attachment/{id}";

        public const string PostGeneralTask = "POST/ GeneralTask";
        public const string PostItemReviewTask = "POST/ ItemReviewTask";
        public const string PostItemReviewTaskAttachment = "POST/ ItemReviewTask/ {taskId}/ Attachment";
        public const string PostItemAuthoringTaskAttachment = "POST/ ItemAuthoringTask/ {taskId}/ Attachment";
        public const string PostStandardSettingTask = "POST/ StandardSettingTask";
        public const string PostStandardSettingTaskAttachment = "POST/ StandardSettingTask/ {taskId}/ Attachment";
        public const string PutGeneralTask = "PUT/ GeneralTask";
        public const string PutItemReviewTask = "PUT/ ItemReviewTask";
        public const string PutStandardSettingTask = "PUT/ StandardSettingTask";
        public const string PutItemReviewResult = "PUT/ItemReviewTask/ ItemReviewResult/{id}";
        public const string PutStandardSettingResult = "PUT/ StandardSettingTask/ StandardSettingResult/ {id}";
        public const string DeleteItemReviewTaskAttachment = "DELETE/ ItemReviewTask/ {taskId}/ Attachment/{id}";

        public const string DeleteItemAuthoringTaskAttachment =
            "DELETE/ ItemAuthoringTask/ {taskId}/ Attachment/{id}";

        public const string DeleteStandardSettingTaskAttachment =
            "DELETE/ StandardSettingTask/ {taskId}/ Attachment/{id}";

        public const string PostCustomReportGenerate = "POST";
        public const string PostCustomReportGenerateHtml = "POST/html";
        public const string PostCustomReportGenerateWrappedHtml = "POST/wrappedhtml";
        public const string GetSectionWithIdAndTestFormId = "GET/{id}/ Section/{sectionId}";
        public const string GetSectionWithIdAndTestFormReference = "GET/{reference}/ Section/{sectionId}";
        public const string PutSectionWithIdAndTestFormId = "PUT/{id}/ Section/{sectionId}";
        public const string PutSectionWithIdAndTestFormReference = "PUT/{reference}/ Section/{sectionId}";
        public const string GetMetadataWithIdAndTestFormId = "GET/{id}/ Metadata/{metadataId}";
        public const string GetMetadataWithIdAndTestFormReference = "GET/{reference}/ Metadata/{metadataId}";
        public const string PutByIdSubmitMarkedExam = "PUT/{id}/ SubmitMarkedExam";
        public const string PutByKeycodeSubmitMarkedExam = "PUT/{keycode}/ SubmitMarkedExam";
        public const string PostItemAuthoringTask = "POST/ ItemAuthoringTask";
        public const string PutItemAuthoringTask = "PUT/ ItemAuthoringTask";
        public const string GetItemAuthoringTaskItem = "GET/ItemAuthoringTask/{id}/Item";
        public const string PutItemAuthoringTaskStatus = "PUT/ItemAuthoringTask/ {taskId}/Status";
        public const string PutItemAuthoringItem = "PUT/ItemAuthoringItem/{id}";
        public const string GetTaskStatistics = "GET/ItemAuthoringTask/{id}/Statistics";

        public const string GetTaskExecutorStatistics =
            "GET/ItemAuthoringTask/{id}/Executor/{executorId}/Statistics";

        public const string GetItemListUserDetails = "GET/ItemAuthoringTask/ItemListUserDetails/{itemListId}";
        public const string PatchWithKeycode = "PATCH/ {keycode}";
        public const string GetTestFormsByTestReference = "GET/{reference}/ TestForms";
        public const string GetTestFormsByTestId = "GET/{id}/TestForms";
        public const string GetItemAuthoringUserDetails = "GET/ItemAuthoringTask/ItemAuthoringUserDetails/{taskId}";
        public const string GetTagsByItemListId = "GET/ItemListTagGroups/{listId}";
        public const string GetStateChangesWithId = "GET/{id}/ StateChanges/";
        public const string GetStateChangesWithKeycode = "GET/{keycode}/ StateChanges/";
        public const string GetTestSessionFileByKeycode = "GET/{keycode}/ File/{fileId}";
        public const string GetTestSessionFileById = "GET/{id}/File/{fileId}";
        public const string PostScannedItemResponsesWithKeycode = "POST/{keycode}/ ScannedItemResponses";
        public const string GetDataById = "GET/{id}/Data";
    }

    public static class MethodOrders
    {
        public const int Get = 1;
        public const int GetWithId = 2;
        public const int GetDataById = 3;
        public const int GetWithKeycode = 3;
        public const int Post = 4;
        public const int Put = 5;
        public const int PutWithKeycod = 6;
        public const int PutWithId = 7;
        public const int Delete = 8;
        public const int DeleteWithId = 9;
        public const int DeleteWithKeycode = 10;
        public const int GetManyItemResponsesForId = 11;
        public const int GetManyItemResponsesForKeycode = 12;
        public const int GetItemWithIdAndPageId = 13;
        public const int GetItemWithKeycodeAndPageId = 14;
        public const int GetCandidateInteractionWithId = 15;
        public const int GetCandidateInteractionWithKeycode = 16;
        public const int GetClientInformationWithId = 17;
        public const int GetClientInformationWithKeycode = 18;
        public const int GetItemAssistiveMediaWithId = 19;
        public const int PutItemAssistiveMediaWithId = 20;
        public const int PostWithKeycodeAndMarksOrder = 6;
        public const int PostItemResponsesWithKeycodeOrder = 7;
        public const int PostScannedItemResponsesWithKeycodeOrder = 8;
        public const int GetItemReviewResults = 23;
        public const int GetItemReviewResultById = 24;
        public const int PutItemReviewResult = 25;
        public const int PutByIdSubmitMarkedExam = 8;
        public const int PutByKeycodeMarkedExam = 9;
        public const int TestSessionPutWithId = 4;
        public const int TestSessionPutWithKeycode = 5;
        public const int GetStateChangesWithId = 26;
        public const int GetStateChangesWithKeycode = 27;
        public const int GetTestSessionFileById = 28;
        public const int GetTestSessionFileByKeycode = 29;
        public const int GetStandardSettingResults = 26;
        public const int GetStandardSettingResultById = 27;
        public const int PutStandardSettingResult = 28;
    }

    public static class ApiControllerOrders
    {
        // v1
        public enum Version1
        {
            TestResults,
            CandidateRegistration,
            Analytics,
            TestSchedule,
        }

        // v2
        public enum Version2
        {
            Centre,
            Subject,
            User,
            Candidate,
            TestSchedule,
            TestSession,
            Result,
            SummaryResult,
            Report,
            Token,
            Permission,
            UserPermission,
            CentreSubjectAssociation,

            TagCategory,
            TagGroup,
            TagCollectionGroup,
            TagValue,
            ItemTagValue,
            Media,
            MediaGroup,
            Folder,
            Item,
            LanguageVariant,
            ItemSet,
            ItemSetLanguageVariant,
            ItemList,
            BasicPage,
            TestProfile,
            Test,
            TestForm,

            AnalyticsResult,
            HistoricalResult,
            RescoringRule,
            ScaleScoreMapping,
            ItemResponse,
            AnalyticsScaleScoreMapping,
            ClientInformation,

            Country,
            County,

            Task,
            TaskAttachment,
            CustomReport,
            CustomReportGeneration,

            WorkflowStatus,
            StateInformation,
        }
    }
}