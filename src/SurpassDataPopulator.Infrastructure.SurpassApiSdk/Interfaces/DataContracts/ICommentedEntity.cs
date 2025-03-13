using SurpassApiSdk.DataContracts.Comment;
using SurpassApiSdk.DataContracts.User;

namespace SurpassApiSdk.Interfaces.DataContracts;

public interface ICommentedEntity
{
    UserResource Owner { get; set; }

    List<CommentResource> Comments { get; set; }
}