﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ChatItem
{
    public TeamMateClass SenderClass;
    public string Message;
    public Color TextColor { get; private set; }

    public ChatItem(TeamMateClass senderClass, string message)
    {
        SenderClass = senderClass;
        Message = message;
        SetChatColor();
    }

    public void SetChatColor()
    {
        switch (SenderClass)
        {
            case TeamMateClass.Rogue:
                TextColor = Color.red;
                break;
            case TeamMateClass.Paladin:
                TextColor = new Color32(150, 146, 36, 255);
                break;
            case TeamMateClass.Wizard:
                TextColor = Color.blue;
                break;
            case TeamMateClass.Warrior:
                TextColor = new Color32(67, 9, 137, 255);
                break;
        }
    }
}
