﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleHealSkill : Skill
{
    public override SkillType SkillType
    {
        get
        {
            return SkillType.SingleHeal;
        }
    }

    public override void CastSkill(List<TeamMate> teamMates, int targetIndex)
    {

    }

    public override bool CanCast(List<TeamMate> teamMates, int targetIndex)
    {
        return true;
    }
}