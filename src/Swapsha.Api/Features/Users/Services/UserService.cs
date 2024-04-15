using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Swapsha.Api.Data;
using Swapsha.Api.Features.Skills.Exceptions;
using Swapsha.Api.Features.Users.Exceptions;
using Swapsha.Api.Features.Users.Models;
using Swapsha.Api.Models;

namespace Swapsha.Api.Features.Users.Services;

public class UserService : IUserService
{
    private readonly AppDbContext _db;
    private readonly UserManager<CustomUser> _userManager;

    public UserService(AppDbContext db, UserManager<CustomUser> userManager)
    {
        _db = db;
        _userManager = userManager;
    }

    public async Task<PaginatedResponse<GetAllUsersResponse>> GetAllUsers(GetAllUsersRequest request)
    {
        var userQuery = _db.Users.AsNoTracking();

        if(request.SkillId.HasValue)
        {
            userQuery = userQuery
                .Where(u => u.UserSkills.Any(us => us.SkillId == request.SkillId));
        }

        var count = await userQuery.CountAsync();

        var users = await userQuery
            .Select(u => new GetAllUsersResponse
            (
                u.Id,
                u.Email,
                u.FirstName + " " + u.LastName,
                u.ProfilePictureUrl,
                u.Reviews.Count(),
                u.Reviews.Any() ? (int?)u.Reviews.Average(r => r.Rating) : null,
                u.UserSkills.Select(s => s.Skill.Name).ToList()
            ))
            .Skip((request.PageIndex - 1) * request.PageSize)
            .Take(request.PageSize)
            .ToListAsync();

        return new PaginatedResponse<GetAllUsersResponse>
        (
            request.PageIndex,
            request.PageSize,
            count,
            users
        );
    }

    public async Task<GetUserResponse> GetUserById(string id)
    {

        var userQuery = _db.Users.AsNoTracking();

        var user = await userQuery
            .Where(u => u.Id == id)
            .Select(u => new GetUserResponse(
            u.Id,
            u.Email,
            u.FirstName,
            u.LastName,
            u.ProfilePictureUrl,
            u.UserSkills.Select(s => new GetUserSkillDto(
                s.Skill.SkillId,
                s.Skill.Name
            )).ToList(),
            u.UserWantedSkills.Select(s => new GetUserSkillDto(
                s.Skill.SkillId,
                s.Skill.Name
                )).ToList()
        )).FirstOrDefaultAsync();

        if (user is null)
        {
            throw new UserNotFoundException($"The user with id: {id} could not be found");
        }

        return user;
    }

    public async Task<GetNamesResponse> GetNamesById(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null)
        {
            throw new UserNotFoundException($"The user with id: {id} could not be found");
        }

        return new GetNamesResponse
        (
            user.FirstName,
            user.MiddleName,
            user.LastName
        );
    }

    public async Task<string> GetFirstNameById(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null)
        {
            throw new UserNotFoundException($"The user with id: {id} could not be found");
        }

        return user.FirstName;
    }

    public async Task<GetProfilePicResponse> GetProfilePicById(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user is null)
        {
            throw new UserNotFoundException($"The user with id: {id} could not be found");
        }

        return new GetProfilePicResponse
        (
            user.Id,
            user.ProfilePictureUrl ?? null
        );
    }

    public async Task AddSkillToUser(string id, int skillId)
    {
        var alreadyHasSkill = await _db.UserSkills.AnyAsync(us => us.UserId == id && us.SkillId == skillId);
        if (alreadyHasSkill)
        {
            throw new DuplicateSkillException($"The user with id: {id} already has the skill with id: {skillId}");
        }

        var skill = await _db.Skills.FindAsync(skillId);
        if (skill is null)
        {
            throw new NoSkillsFoundException($"The skill with the id: {skillId} could not be found");
        }

        var userSkill = new UserSkill
        {
            SkillId = skill.SkillId,
            UserId = id
        };

        _db.UserSkills.Add(userSkill);

        await _db.SaveChangesAsync();
    }

    public async Task AddWantedSkillToUser(string id, int skillId)
    {
        var alreadyHasWantedSkill = await _db.UserWantedSkills.AnyAsync(us => us.UserId == id && us.SkillId == skillId);
        if (alreadyHasWantedSkill)
        {
            throw new DuplicateWantedSkillException($"The user with id: {id} already has the wanted skill with id: {skillId}");
        }

        var skill = await _db.Skills.FindAsync(skillId);
        if (skill is null)
        {
            throw new NoSkillsFoundException($"The skill with the id: {skillId} could not be found");
        }

        var userWantedSkill = new UserWantedSkill
        {
            SkillId = skill.SkillId,
            UserId = id
        };

        _db.UserWantedSkills.Add(userWantedSkill);

        await _db.SaveChangesAsync();
    }
}