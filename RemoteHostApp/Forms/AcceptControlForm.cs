using System;
using System.Windows.Forms;

namespace RemoteHostApp.Forms;

/// <summary>
/// Popup hiển thị khi có viewer yêu cầu điều khiển máy.
/// Host có thể chấp nhận hoặc từ chối với lý do tuỳ chọn.
/// </summary>
public partial class AcceptControlForm : Form
{
    public bool IsAccepted { get; private set; }
    public string? RejectReason { get; private set; }

    private readonly string _viewerName;
    private readonly string _sessionId;

    public AcceptControlForm(string viewerName, string sessionId)
    {
        _viewerName = viewerName;
        _sessionId = sessionId;
        InitializeComponent();
        lblMessage.Text = $"Viewer \"{viewerName}\" muốn điều khiển máy của bạn.\n\nSession ID: {sessionId}";
    }

    //  Event handlers 

    private void BtnAccept_Click(object? sender, EventArgs e)
    {
        IsAccepted = true;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnReject_Click(object? sender, EventArgs e)
    {
        IsAccepted = false;
        RejectReason = string.IsNullOrWhiteSpace(txtRejectReason.Text)
            ? null : txtRejectReason.Text.Trim();
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
