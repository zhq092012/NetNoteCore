// /Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote.Models/Note.cs// 2019/12/19// zhanghuqiang-zhq_092012@163.comusing System.Collections.Generic;using System.ComponentModel.DataAnnotations;using System.ComponentModel.DataAnnotations.Schema;

namespace NetNote.Models{  /// <summary>  /// 笔记类型  /// </summary>  public class NoteType  {
    [Key]    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    public int Id { get; set; }    [Required]    [MaxLength(50)]    public string Name { get; set; }    public List<Note> Notes { get; set; }  }}