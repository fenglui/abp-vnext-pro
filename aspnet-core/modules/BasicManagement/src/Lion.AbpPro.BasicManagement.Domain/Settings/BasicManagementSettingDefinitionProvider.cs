﻿using Lion.AbpPro.BasicManagement.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;
using Volo.Abp.Timing;

namespace Lion.AbpPro.BasicManagement.Settings;

public class BasicManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BasicManagementSettings.MySetting1));
        OverrideDefaultSettings(context);
    }

    /// <summary>
    /// 重写默认setting添加自定义属性
    /// </summary>
    private static void OverrideDefaultSettings(ISettingDefinitionContext context)
    {
        context.Add(
            new SettingDefinition(TimingSettingNames.TimeZone,
                    "China Standard Time",
                    L("DisplayName:Abp.Timing.Timezone"),
                    L("Description:Abp.Timing.Timezone"))
                .WithProperty(BasicManagementSettings.Group.Default,
                    BasicManagementSettings.Group.SystemManagement)
                .WithProperty(BasicManagementSettings.ControlType.Default,
                    BasicManagementSettings.ControlType.TypeText));

        context.GetOrNull("Abp.Identity.Password.RequiredLength")
            .WithProperty(BasicManagementSettings.Group.Default,
                BasicManagementSettings.Group.SystemManagement)
            .WithProperty(BasicManagementSettings.ControlType.Default,
                BasicManagementSettings.ControlType.Number);

        context.GetOrNull("Abp.Identity.Password.RequiredLength")
            .WithProperty(BasicManagementSettings.Group.Default,
                BasicManagementSettings.Group.SystemManagement)
            .WithProperty(BasicManagementSettings.ControlType.Default,
                BasicManagementSettings.ControlType.Number);

        context.GetOrNull("Abp.Identity.Password.RequiredUniqueChars")
            .WithProperty(BasicManagementSettings.Group.Default,
                BasicManagementSettings.Group.SystemManagement)
            .WithProperty(BasicManagementSettings.ControlType.Default,
                BasicManagementSettings.ControlType.Number);

        context.GetOrNull("Abp.Identity.Password.RequireNonAlphanumeric")
            .WithProperty(BasicManagementSettings.Group.Default,
                BasicManagementSettings.Group.SystemManagement)
            .WithProperty(BasicManagementSettings.ControlType.Default,
                BasicManagementSettings.ControlType.TypeCheckBox);

        context.GetOrNull("Abp.Identity.Password.RequireLowercase")
            .WithProperty(BasicManagementSettings.Group.Default,
                BasicManagementSettings.Group.SystemManagement)
            .WithProperty(BasicManagementSettings.ControlType.Default,
                BasicManagementSettings.ControlType.TypeCheckBox);

        context.GetOrNull("Abp.Identity.Password.RequireUppercase")
            .WithProperty(BasicManagementSettings.Group.Default,
                BasicManagementSettings.Group.SystemManagement)
            .WithProperty(BasicManagementSettings.ControlType.Default,
                BasicManagementSettings.ControlType.TypeCheckBox);

        context.GetOrNull("Abp.Identity.Password.RequireDigit")
            .WithProperty(BasicManagementSettings.Group.Default,
                BasicManagementSettings.Group.SystemManagement)
            .WithProperty(BasicManagementSettings.ControlType.Default,
                BasicManagementSettings.ControlType.TypeCheckBox);
    }


    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BasicManagementResource>(name);
    }
}