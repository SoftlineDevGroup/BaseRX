namespace Sungero.Docflow.Structures.AssignmentCompletionReport
{
  [global::System.Serializable]
  public partial class TableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TableLine Create()
    {
      return new TableLine();
    }

    public static TableLine Create(global::System.String reportSessionId, global::System.Int32 assignmentId, global::System.Int32 performer, global::System.String employeeName, global::System.String jobTitle, global::System.String department, global::System.Int32 task, global::System.String subject, global::System.Int32 author, global::System.String authorName, global::System.DateTime created, global::System.Nullable<global::System.DateTime> deadline, global::System.Nullable<global::System.DateTime> completed, global::System.Boolean isRead, global::System.String status, global::System.String createdTime, global::System.String deadlineTime, global::System.String completedTime, global::System.String delay, global::System.Int32 delaySort, global::System.String assignmentStatus, global::System.String hyperLink)
    {
      return new TableLine
      {
        ReportSessionId = reportSessionId,
        AssignmentId = assignmentId,
        Performer = performer,
        EmployeeName = employeeName,
        JobTitle = jobTitle,
        Department = department,
        Task = task,
        Subject = subject,
        Author = author,
        AuthorName = authorName,
        Created = created,
        Deadline = deadline,
        Completed = completed,
        IsRead = isRead,
        Status = status,
        CreatedTime = createdTime,
        DeadlineTime = deadlineTime,
        CompletedTime = completedTime,
        Delay = delay,
        DelaySort = delaySort,
        AssignmentStatus = assignmentStatus,
        HyperLink = hyperLink
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ (this.AssignmentId.GetHashCode() * 199) ^ (this.Performer.GetHashCode() * 199) ^ ((this.EmployeeName != null ? this.EmployeeName.GetHashCode() : 0) * 199) ^ ((this.JobTitle != null ? this.JobTitle.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ (this.Task.GetHashCode() * 199) ^ ((this.Subject != null ? this.Subject.GetHashCode() : 0) * 199) ^ (this.Author.GetHashCode() * 199) ^ ((this.AuthorName != null ? this.AuthorName.GetHashCode() : 0) * 199) ^ ((this.Created != null ? this.Created.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Completed != null ? this.Completed.GetHashCode() : 0) * 199) ^ (this.IsRead.GetHashCode() * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199) ^ ((this.CreatedTime != null ? this.CreatedTime.GetHashCode() : 0) * 199) ^ ((this.DeadlineTime != null ? this.DeadlineTime.GetHashCode() : 0) * 199) ^ ((this.CompletedTime != null ? this.CompletedTime.GetHashCode() : 0) * 199) ^ ((this.Delay != null ? this.Delay.GetHashCode() : 0) * 199) ^ (this.DelaySort.GetHashCode() * 199) ^ ((this.AssignmentStatus != null ? this.AssignmentStatus.GetHashCode() : 0) * 199) ^ ((this.HyperLink != null ? this.HyperLink.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((TableLine)obj);
    }

    public static bool operator ==(TableLine left, TableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(TableLine left, TableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(TableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId)
             && this.AssignmentId == other.AssignmentId
             && this.Performer == other.Performer
             && object.Equals(this.EmployeeName, other.EmployeeName)
             && object.Equals(this.JobTitle, other.JobTitle)
             && object.Equals(this.Department, other.Department)
             && this.Task == other.Task
             && object.Equals(this.Subject, other.Subject)
             && this.Author == other.Author
             && object.Equals(this.AuthorName, other.AuthorName)
             && object.Equals(this.Created, other.Created)
             && object.Equals(this.Deadline, other.Deadline)
             && object.Equals(this.Completed, other.Completed)
             && this.IsRead == other.IsRead
             && object.Equals(this.Status, other.Status)
             && object.Equals(this.CreatedTime, other.CreatedTime)
             && object.Equals(this.DeadlineTime, other.DeadlineTime)
             && object.Equals(this.CompletedTime, other.CompletedTime)
             && object.Equals(this.Delay, other.Delay)
             && this.DelaySort == other.DelaySort
             && object.Equals(this.AssignmentStatus, other.AssignmentStatus)
             && object.Equals(this.HyperLink, other.HyperLink);
    }
  }
}