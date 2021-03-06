﻿// https://docs.microsoft.com/en-us/visualstudio/modeling/t4-include-directive?view=vs-2017
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Bot.Solutions.Dialogs;

namespace FakeSkill.Dialogs.Auth
{
    /// <summary>
    /// Contains bot responses.
    /// </summary>
    public static class SampleAuthResponses
    {
        private static readonly ResponseManager _responseManager;

        static SampleAuthResponses()
        {
            var dir = Path.GetDirectoryName(typeof(SampleAuthResponses).Assembly.Location);
            var resDir = Path.Combine(dir, @"Skills\Fakes\FakeSkill\Dialogs\Auth\Resources");
            _responseManager = new ResponseManager(resDir, "SampleResponses");
        }

        // Generated accessors
        public static BotResponse MessagePrompt => GetBotResponse();

        public static BotResponse MessageResponse => GetBotResponse();

        private static BotResponse GetBotResponse([CallerMemberName] string propertyName = null)
        {
            return _responseManager.GetBotResponse(propertyName);
        }
    }
}