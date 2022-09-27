using TodoApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TodoApp.Permissions;

public class TodoAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(TodoAppPermissions.GroupName);

        var booksPermission = bookStoreGroup.AddPermission(TodoAppPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(TodoAppPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(TodoAppPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(TodoAppPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = bookStoreGroup.AddPermission(
        TodoAppPermissions.Authors.Default, L("Permission:Authors"));

        authorsPermission.AddChild(
            TodoAppPermissions.Authors.Create, L("Permission:Authors.Create"));

        authorsPermission.AddChild(
            TodoAppPermissions.Authors.Edit, L("Permission:Authors.Edit"));

        authorsPermission.AddChild(
            TodoAppPermissions.Authors.Delete, L("Permission:Authors.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TodoAppResource>(name);
    }
}
