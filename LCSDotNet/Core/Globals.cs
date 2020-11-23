using System.Collections.Generic;

namespace LCSDotNet.Core
{
    public class Globals
    {
        public static Globals instance;

        public CCSOptions ccsOption;
        public LCSOptions lcsOptions;
        public AgendaOptions agendaOption;
        public SkillOptions skillOption;

        public Globals()
        {
            instance = this;
            ccsOption = CCSOptions.None;
            lcsOptions = LCSOptions.None;
            agendaOption = AgendaOptions.Classic;
            skillOption = SkillOptions.Fast;
        }
    }

    public enum CCSOptions
    {
        None,
        ClassicMode,
        WeDidntStart
    }

    public enum LCSOptions
    {
        None,
        NightmareMode,
        NationalLCS,
        MarathonMode,
        NationalNightmare,
        NationalMarathon,
        NightmareMarathon,
        All
    }

    public enum AgendaOptions
    {
        Classic,
        Democrat
    }

    public enum SkillOptions
    {
        Fast,
        Classic,
        Hard
    }
}