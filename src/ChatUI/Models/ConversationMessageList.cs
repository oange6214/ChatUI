using System.Windows;

namespace ChatUI.Models;

public class ConversationMessageList
{
    public Visibility IsAudioTrack { get; set; }
    public string Message { get; set; }
    public string MessageStatus { get; set; }
    public string TimeStamp { get; set; }
}