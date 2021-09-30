namespace Sungero.Shell.Structures.Module
{
  public partial class DepartmentLoad : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DepartmentLoad Create()
    {
      return new DepartmentLoad();
    }

    public static DepartmentLoad Create(global::Sungero.Company.IDepartment department, global::System.Int32 allAssignment, global::System.Int32 overduedAssignment)
    {
      return new DepartmentLoad
      {
        Department = department,
        AllAssignment = allAssignment,
        OverduedAssignment = overduedAssignment
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Department != null ? this.Department.GetHashCode() : 0) * 199) ^ (this.AllAssignment.GetHashCode() * 199) ^ (this.OverduedAssignment.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentLoad)obj);
    }

    public static bool operator ==(DepartmentLoad left, DepartmentLoad right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentLoad left, DepartmentLoad right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentLoad other)
    {
      return object.Equals(this.Department, other.Department)
             && this.AllAssignment == other.AllAssignment
             && this.OverduedAssignment == other.OverduedAssignment;
    }
  }

  public partial class PerformerLoad : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static PerformerLoad Create()
    {
      return new PerformerLoad();
    }

    public static PerformerLoad Create(global::Sungero.Company.IEmployee employee, global::System.Int32 allAssignment, global::System.Int32 overduedAssignment)
    {
      return new PerformerLoad
      {
        Employee = employee,
        AllAssignment = allAssignment,
        OverduedAssignment = overduedAssignment
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Employee != null ? this.Employee.GetHashCode() : 0) * 199) ^ (this.AllAssignment.GetHashCode() * 199) ^ (this.OverduedAssignment.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PerformerLoad)obj);
    }

    public static bool operator ==(PerformerLoad left, PerformerLoad right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PerformerLoad left, PerformerLoad right)
    {
      return !(left == right);
    }

    protected bool Equals(PerformerLoad other)
    {
      return object.Equals(this.Employee, other.Employee)
             && this.AllAssignment == other.AllAssignment
             && this.OverduedAssignment == other.OverduedAssignment;
    }
  }

  [global::System.Serializable]
  public partial class PlotDatePoint : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static PlotDatePoint Create()
    {
      return new PlotDatePoint();
    }

    public static PlotDatePoint Create(global::System.String typeDiscriminator, global::System.DateTime date, global::System.Int32 count)
    {
      return new PlotDatePoint
      {
        TypeDiscriminator = typeDiscriminator,
        Date = date,
        Count = count
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.TypeDiscriminator != null ? this.TypeDiscriminator.GetHashCode() : 0) * 199) ^ ((this.Date != null ? this.Date.GetHashCode() : 0) * 199) ^ (this.Count.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PlotDatePoint)obj);
    }

    public static bool operator ==(PlotDatePoint left, PlotDatePoint right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PlotDatePoint left, PlotDatePoint right)
    {
      return !(left == right);
    }

    protected bool Equals(PlotDatePoint other)
    {
      return object.Equals(this.TypeDiscriminator, other.TypeDiscriminator)
             && object.Equals(this.Date, other.Date)
             && this.Count == other.Count;
    }
  }

  [global::System.Serializable]
  public partial class DateCountPoint : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DateCountPoint Create()
    {
      return new DateCountPoint();
    }

    public static DateCountPoint Create(global::System.DateTime date, global::System.Double count)
    {
      return new DateCountPoint
      {
        Date = date,
        Count = count
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Date != null ? this.Date.GetHashCode() : 0) * 199) ^ (this.Count.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DateCountPoint)obj);
    }

    public static bool operator ==(DateCountPoint left, DateCountPoint right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DateCountPoint left, DateCountPoint right)
    {
      return !(left == right);
    }

    protected bool Equals(DateCountPoint other)
    {
      return object.Equals(this.Date, other.Date)
             && this.Count == other.Count;
    }
  }

  [global::System.Serializable]
  public partial class ObjectCreateDynamicCache : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ObjectCreateDynamicCache Create()
    {
      return new ObjectCreateDynamicCache();
    }

    public static ObjectCreateDynamicCache Create(global::System.Nullable<global::System.Int32> employeeId, global::System.Collections.Generic.List<global::System.Int32> usersId, global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.PlotDatePoint> points, global::System.Nullable<global::System.DateTime> lastUpdate, global::System.Boolean isChanged)
    {
      return new ObjectCreateDynamicCache
      {
        EmployeeId = employeeId,
        UsersId = usersId,
        Points = points,
        LastUpdate = lastUpdate,
        IsChanged = isChanged
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.EmployeeId != null ? this.EmployeeId.GetHashCode() : 0) * 199) ^ ((this.UsersId != null ? this.UsersId.GetHashCode() : 0) * 199) ^ ((this.Points != null ? this.Points.GetHashCode() : 0) * 199) ^ ((this.LastUpdate != null ? this.LastUpdate.GetHashCode() : 0) * 199) ^ (this.IsChanged.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ObjectCreateDynamicCache)obj);
    }

    public static bool operator ==(ObjectCreateDynamicCache left, ObjectCreateDynamicCache right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ObjectCreateDynamicCache left, ObjectCreateDynamicCache right)
    {
      return !(left == right);
    }

    protected bool Equals(ObjectCreateDynamicCache other)
    {
      return object.Equals(this.EmployeeId, other.EmployeeId)
             && global::System.Linq.Enumerable.SequenceEqual(this.UsersId, other.UsersId)
             && global::System.Linq.Enumerable.SequenceEqual(this.Points, other.Points)
             && object.Equals(this.LastUpdate, other.LastUpdate)
             && this.IsChanged == other.IsChanged;
    }
  }

  [global::System.Serializable]
  public partial class LightAssignment : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LightAssignment Create()
    {
      return new LightAssignment();
    }

    public static LightAssignment Create(global::System.Int32 id, global::System.Nullable<global::Sungero.Core.Enumeration> status, global::System.Nullable<global::System.DateTime> deadline, global::System.Nullable<global::System.DateTime> modified, global::System.Nullable<global::System.DateTime> created, global::System.Int32 performerId, global::System.Nullable<global::System.DateTime> factDeadline, global::System.Nullable<global::System.DateTime> completed)
    {
      return new LightAssignment
      {
        Id = id,
        Status = status,
        Deadline = deadline,
        Modified = modified,
        Created = created,
        PerformerId = performerId,
        FactDeadline = factDeadline,
        Completed = completed
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Modified != null ? this.Modified.GetHashCode() : 0) * 199) ^ ((this.Created != null ? this.Created.GetHashCode() : 0) * 199) ^ (this.PerformerId.GetHashCode() * 199) ^ ((this.FactDeadline != null ? this.FactDeadline.GetHashCode() : 0) * 199) ^ ((this.Completed != null ? this.Completed.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightAssignment)obj);
    }

    public static bool operator ==(LightAssignment left, LightAssignment right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightAssignment left, LightAssignment right)
    {
      return !(left == right);
    }

    protected bool Equals(LightAssignment other)
    {
      return this.Id == other.Id
             && object.Equals(this.Status, other.Status)
             && object.Equals(this.Deadline, other.Deadline)
             && object.Equals(this.Modified, other.Modified)
             && object.Equals(this.Created, other.Created)
             && this.PerformerId == other.PerformerId
             && object.Equals(this.FactDeadline, other.FactDeadline)
             && object.Equals(this.Completed, other.Completed);
    }
  }

  [global::System.Serializable]
  public partial class PerformerLoadUniqueNames : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static PerformerLoadUniqueNames Create()
    {
      return new PerformerLoadUniqueNames();
    }

    public static PerformerLoadUniqueNames Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.PerformerLoad performerLoad)
    {
      return new PerformerLoadUniqueNames
      {
        UniqueName = uniqueName,
        PerformerLoad = performerLoad
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.PerformerLoad != null ? this.PerformerLoad.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PerformerLoadUniqueNames)obj);
    }

    public static bool operator ==(PerformerLoadUniqueNames left, PerformerLoadUniqueNames right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PerformerLoadUniqueNames left, PerformerLoadUniqueNames right)
    {
      return !(left == right);
    }

    protected bool Equals(PerformerLoadUniqueNames other)
    {
      return object.Equals(this.UniqueName, other.UniqueName)
             && object.Equals(this.PerformerLoad, other.PerformerLoad);
    }
  }

  [global::System.Serializable]
  public partial class DepartmentLoadUniqueNames : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DepartmentLoadUniqueNames Create()
    {
      return new DepartmentLoadUniqueNames();
    }

    public static DepartmentLoadUniqueNames Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.DepartmentLoad departmentLoad)
    {
      return new DepartmentLoadUniqueNames
      {
        UniqueName = uniqueName,
        DepartmentLoad = departmentLoad
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.DepartmentLoad != null ? this.DepartmentLoad.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentLoadUniqueNames)obj);
    }

    public static bool operator ==(DepartmentLoadUniqueNames left, DepartmentLoadUniqueNames right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentLoadUniqueNames left, DepartmentLoadUniqueNames right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentLoadUniqueNames other)
    {
      return object.Equals(this.UniqueName, other.UniqueName)
             && object.Equals(this.DepartmentLoad, other.DepartmentLoad);
    }
  }

  [global::System.Serializable]
  public partial class CachedAssignment : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static CachedAssignment Create()
    {
      return new CachedAssignment();
    }

    public static CachedAssignment Create(global::System.Int32 id, global::System.Nullable<global::System.DateTime> created, global::System.Nullable<global::System.DateTime> deadline, global::System.Nullable<global::System.DateTime> completed, global::System.Nullable<global::System.Boolean> hasOverdue, global::System.Nullable<global::System.DateTime> lastUpdate, global::System.Int32 performerId)
    {
      return new CachedAssignment
      {
        Id = id,
        Created = created,
        Deadline = deadline,
        Completed = completed,
        HasOverdue = hasOverdue,
        LastUpdate = lastUpdate,
        PerformerId = performerId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Created != null ? this.Created.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Completed != null ? this.Completed.GetHashCode() : 0) * 199) ^ ((this.HasOverdue != null ? this.HasOverdue.GetHashCode() : 0) * 199) ^ ((this.LastUpdate != null ? this.LastUpdate.GetHashCode() : 0) * 199) ^ (this.PerformerId.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((CachedAssignment)obj);
    }

    public static bool operator ==(CachedAssignment left, CachedAssignment right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(CachedAssignment left, CachedAssignment right)
    {
      return !(left == right);
    }

    protected bool Equals(CachedAssignment other)
    {
      return this.Id == other.Id
             && object.Equals(this.Created, other.Created)
             && object.Equals(this.Deadline, other.Deadline)
             && object.Equals(this.Completed, other.Completed)
             && object.Equals(this.HasOverdue, other.HasOverdue)
             && object.Equals(this.LastUpdate, other.LastUpdate)
             && this.PerformerId == other.PerformerId;
    }
  }

  [global::System.Serializable]
  public partial class LightUser : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LightUser Create()
    {
      return new LightUser();
    }

    public static LightUser Create(global::System.Int32 userId, global::System.Nullable<global::System.Double> timeZone)
    {
      return new LightUser
      {
        UserId = userId,
        TimeZone = timeZone
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.UserId.GetHashCode() * 199) ^ ((this.TimeZone != null ? this.TimeZone.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LightUser)obj);
    }

    public static bool operator ==(LightUser left, LightUser right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LightUser left, LightUser right)
    {
      return !(left == right);
    }

    protected bool Equals(LightUser other)
    {
      return this.UserId == other.UserId
             && object.Equals(this.TimeZone, other.TimeZone);
    }
  }

  [global::System.Serializable]
  public partial class EmployeeAssignmentsCache : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static EmployeeAssignmentsCache Create()
    {
      return new EmployeeAssignmentsCache();
    }

    public static EmployeeAssignmentsCache Create(global::Sungero.Shell.Structures.Module.LightUser user, global::System.Nullable<global::System.Int32> departmentId, global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.LightUser> users, global::System.Nullable<global::System.DateTime> modified, global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.CachedAssignment> assignments, global::System.Int32 asgCount30, global::System.Int32 asgInTimeCount30, global::System.Int32 asgOverdueCount30, global::System.Int32 asgCount90, global::System.Int32 asgInTimeCount90, global::System.Int32 asgOverdueCount90, global::System.Boolean isChanged)
    {
      return new EmployeeAssignmentsCache
      {
        User = user,
        DepartmentId = departmentId,
        Users = users,
        Modified = modified,
        Assignments = assignments,
        AsgCount30 = asgCount30,
        AsgInTimeCount30 = asgInTimeCount30,
        AsgOverdueCount30 = asgOverdueCount30,
        AsgCount90 = asgCount90,
        AsgInTimeCount90 = asgInTimeCount90,
        AsgOverdueCount90 = asgOverdueCount90,
        IsChanged = isChanged
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.User != null ? this.User.GetHashCode() : 0) * 199) ^ ((this.DepartmentId != null ? this.DepartmentId.GetHashCode() : 0) * 199) ^ ((this.Users != null ? this.Users.GetHashCode() : 0) * 199) ^ ((this.Modified != null ? this.Modified.GetHashCode() : 0) * 199) ^ ((this.Assignments != null ? this.Assignments.GetHashCode() : 0) * 199) ^ (this.AsgCount30.GetHashCode() * 199) ^ (this.AsgInTimeCount30.GetHashCode() * 199) ^ (this.AsgOverdueCount30.GetHashCode() * 199) ^ (this.AsgCount90.GetHashCode() * 199) ^ (this.AsgInTimeCount90.GetHashCode() * 199) ^ (this.AsgOverdueCount90.GetHashCode() * 199) ^ (this.IsChanged.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((EmployeeAssignmentsCache)obj);
    }

    public static bool operator ==(EmployeeAssignmentsCache left, EmployeeAssignmentsCache right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(EmployeeAssignmentsCache left, EmployeeAssignmentsCache right)
    {
      return !(left == right);
    }

    protected bool Equals(EmployeeAssignmentsCache other)
    {
      return object.Equals(this.User, other.User)
             && object.Equals(this.DepartmentId, other.DepartmentId)
             && global::System.Linq.Enumerable.SequenceEqual(this.Users, other.Users)
             && object.Equals(this.Modified, other.Modified)
             && global::System.Linq.Enumerable.SequenceEqual(this.Assignments, other.Assignments)
             && this.AsgCount30 == other.AsgCount30
             && this.AsgInTimeCount30 == other.AsgInTimeCount30
             && this.AsgOverdueCount30 == other.AsgOverdueCount30
             && this.AsgCount90 == other.AsgCount90
             && this.AsgInTimeCount90 == other.AsgInTimeCount90
             && this.AsgOverdueCount90 == other.AsgOverdueCount90
             && this.IsChanged == other.IsChanged;
    }
  }

  public partial class DepartmentDiscipline : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DepartmentDiscipline Create()
    {
      return new DepartmentDiscipline();
    }

    public static DepartmentDiscipline Create(global::System.Nullable<global::System.Int32> discipline, global::Sungero.Company.IDepartment department)
    {
      return new DepartmentDiscipline
      {
        Discipline = discipline,
        Department = department
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Discipline != null ? this.Discipline.GetHashCode() : 0) * 199) ^ ((this.Department != null ? this.Department.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentDiscipline)obj);
    }

    public static bool operator ==(DepartmentDiscipline left, DepartmentDiscipline right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentDiscipline left, DepartmentDiscipline right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentDiscipline other)
    {
      return object.Equals(this.Discipline, other.Discipline)
             && object.Equals(this.Department, other.Department);
    }
  }

  public partial class EmployeeDiscipline : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static EmployeeDiscipline Create()
    {
      return new EmployeeDiscipline();
    }

    public static EmployeeDiscipline Create(global::System.Nullable<global::System.Int32> discipline, global::Sungero.Company.IEmployee employee, global::System.Int32 overdueAsg)
    {
      return new EmployeeDiscipline
      {
        Discipline = discipline,
        Employee = employee,
        OverdueAsg = overdueAsg
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Discipline != null ? this.Discipline.GetHashCode() : 0) * 199) ^ ((this.Employee != null ? this.Employee.GetHashCode() : 0) * 199) ^ (this.OverdueAsg.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((EmployeeDiscipline)obj);
    }

    public static bool operator ==(EmployeeDiscipline left, EmployeeDiscipline right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(EmployeeDiscipline left, EmployeeDiscipline right)
    {
      return !(left == right);
    }

    protected bool Equals(EmployeeDiscipline other)
    {
      return object.Equals(this.Discipline, other.Discipline)
             && object.Equals(this.Employee, other.Employee)
             && this.OverdueAsg == other.OverdueAsg;
    }
  }

  [global::System.Serializable]
  public partial class EmployeeDisciplineUniqueName : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static EmployeeDisciplineUniqueName Create()
    {
      return new EmployeeDisciplineUniqueName();
    }

    public static EmployeeDisciplineUniqueName Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.EmployeeDiscipline employeeDiscipline)
    {
      return new EmployeeDisciplineUniqueName
      {
        UniqueName = uniqueName,
        EmployeeDiscipline = employeeDiscipline
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.EmployeeDiscipline != null ? this.EmployeeDiscipline.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((EmployeeDisciplineUniqueName)obj);
    }

    public static bool operator ==(EmployeeDisciplineUniqueName left, EmployeeDisciplineUniqueName right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(EmployeeDisciplineUniqueName left, EmployeeDisciplineUniqueName right)
    {
      return !(left == right);
    }

    protected bool Equals(EmployeeDisciplineUniqueName other)
    {
      return object.Equals(this.UniqueName, other.UniqueName)
             && object.Equals(this.EmployeeDiscipline, other.EmployeeDiscipline);
    }
  }

  [global::System.Serializable]
  public partial class DepartmentDisciplineUniqueName : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DepartmentDisciplineUniqueName Create()
    {
      return new DepartmentDisciplineUniqueName();
    }

    public static DepartmentDisciplineUniqueName Create(global::System.String uniqueName, global::Sungero.Shell.Structures.Module.DepartmentDiscipline departmentDiscipline)
    {
      return new DepartmentDisciplineUniqueName
      {
        UniqueName = uniqueName,
        DepartmentDiscipline = departmentDiscipline
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.UniqueName != null ? this.UniqueName.GetHashCode() : 0) * 199) ^ ((this.DepartmentDiscipline != null ? this.DepartmentDiscipline.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DepartmentDisciplineUniqueName)obj);
    }

    public static bool operator ==(DepartmentDisciplineUniqueName left, DepartmentDisciplineUniqueName right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DepartmentDisciplineUniqueName left, DepartmentDisciplineUniqueName right)
    {
      return !(left == right);
    }

    protected bool Equals(DepartmentDisciplineUniqueName other)
    {
      return object.Equals(this.UniqueName, other.UniqueName)
             && object.Equals(this.DepartmentDiscipline, other.DepartmentDiscipline);
    }
  }

  [global::System.Serializable]
  public partial class AssignmentChartGroup : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AssignmentChartGroup Create()
    {
      return new AssignmentChartGroup();
    }

    public static AssignmentChartGroup Create(global::System.String constantName, global::System.String resource, global::System.Int32 count)
    {
      return new AssignmentChartGroup
      {
        ConstantName = constantName,
        Resource = resource,
        Count = count
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ConstantName != null ? this.ConstantName.GetHashCode() : 0) * 199) ^ ((this.Resource != null ? this.Resource.GetHashCode() : 0) * 199) ^ (this.Count.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AssignmentChartGroup)obj);
    }

    public static bool operator ==(AssignmentChartGroup left, AssignmentChartGroup right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AssignmentChartGroup left, AssignmentChartGroup right)
    {
      return !(left == right);
    }

    protected bool Equals(AssignmentChartGroup other)
    {
      return object.Equals(this.ConstantName, other.ConstantName)
             && object.Equals(this.Resource, other.Resource)
             && this.Count == other.Count;
    }
  }
}