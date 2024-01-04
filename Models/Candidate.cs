namespace VSS.Models;

public class Candidate
{
    public int CandidateId { get; set; }
    public int AdminFileId { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string Email { get; set; }
    public string HashedEmail { get; set; }
    public string Status { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string LinkedId { get; set; }
    public string Name => $"{Firstname} {Lastname}";
    public string NameLastFirst => $"{Lastname} {Firstname}";
    public string NameSimpleSearch => $"{Firstname} {Lastname}";
    public string LastInterviewGrade { get; set; }
    public int? TotalExperienceYears { get; set; }
    public DateTime PublishingDate { get; set; }
    public DateTime IndexingDate { get; set; }
    public DateTime? LastUpdatedDate { get; set; }
    public DateTime? LastSourcingDate { get; set; }
    public int Score { get; set; }
    public double? ElasticSearchScore { get; set; }
    public string Holding { get; set; }
    public bool IsCoopted { get; set; }
    public bool IsAlreadySeenByLoggedEmployee { get; set; } // Empty for the moment
                                                            // Consultant
    public DateTime? LastProjectEndDate { get; set; }
    public int? LastGraduationYear { get; set; }
    public string EmployeeTrigram { get; set; }
    public string EmployeeScopeLabel { get; set; }
    public string EmployeeManagerId { get; set; }
    public string CurrentOrLastProjectClientSector { get; set; }
    public int? ConsultantFileId { get; set; }
    public DateTime? ConsultantFileDate { get; set; }
    public DateTime? ExitDate { get; set; }
    public int? EmployeeId { get; set; }
    public int? ClosedProfileEmployeeId { get; set; }
    public string CurrentVector { get; set; }
    public double ConfidenceRate { get; set; }
}
