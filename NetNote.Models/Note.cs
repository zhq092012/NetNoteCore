// /Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote.Models/Note.cs
// 2019/12/19
// zhanghuqiang-zhq_092012@163.com
using System;using System.ComponentModel.DataAnnotations;namespace NetNote.Models{
  /// <summary>
  /// 笔记
  /// </summary>  public class Note  {    public int Id { get; set; }
    [Required]
    [MaxLength(100)]    public string Title { get; set; }
    [Required]    public string Content { get; set; }    public DateTime CreateDate { get; set; }
    public string Password { get; set; }
    public string Attachment { get; set; }
    public int TypeId { get; set; }
    public NoteType Type { get; set; }
  }}