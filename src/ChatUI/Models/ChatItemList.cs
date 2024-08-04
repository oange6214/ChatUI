namespace ChatUI.Models;

public class ChatItemList
{
    public string Availability { get; set; }
    public string ContactName { get; set; }
    public string ContactProfilePicUri { get; set; }
    public bool IsChatSelected { get; set; }
    public bool IsOnline { get; set; }
    public bool IsRead { get; set; }
    public string LastMessageTime { get; set; }
    public string Message { get; set; }
    public string NewMsgCount { get; set; }
}