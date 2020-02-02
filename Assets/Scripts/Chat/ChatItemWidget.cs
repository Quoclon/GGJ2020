﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatItemWidget : MonoBehaviour
{
    public Text chatMessage;

    public void Init(ChatItem chatItem) 
    {
        chatMessage.text = chatItem.Message;
        chatMessage.color = chatItem.TextColor;
    }
}
