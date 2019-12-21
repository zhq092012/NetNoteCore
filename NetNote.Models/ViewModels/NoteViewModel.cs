// /Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote/ViewModels/NoteViewModel.cs
// 2019/12/19
// zhanghuqiang-zhq_092012@163.com
using System;using System.ComponentModel.DataAnnotations;using Microsoft.AspNetCore.Http;namespace NetNote.Models.ViewModels{
  public class NoteViewModel
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    [Display(Name = "标题")]
    public string Title { get; set; }
    [Required]
    [Display(Name = "内容")]
    public string Content { get; set; }
    [Display(Name = "创建日期")]
    public DateTime CreateDate { get; set; }
    [Display(Name = "类型")]
    [Required]
    public int Type { get; set; }
    [Display(Name = "密码")]
    public string Password { get; set; }
    [Display(Name = "附件")]
    public IFormFile Attachment { get; set; }

    //api
    public string TypeName { get; set; }
    public string AttachPath { get; set; }
  }}