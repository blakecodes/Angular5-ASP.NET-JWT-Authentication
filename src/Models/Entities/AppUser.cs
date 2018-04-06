
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
    // Add profile data for application users by adding properties to this class
  public class AppUser : IdentityUser
  {
    [MaxLength(36)]
    public override string Id { get; set; }
    [MaxLength(256)]
    public string LoginProvider { get; set; }
    [MaxLength(256)]
    public string ProviderKey { get; set; }

    // Extended Properties
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public long? FacebookId { get; set; }
    public string PictureUrl { get; set; }
  }
}
