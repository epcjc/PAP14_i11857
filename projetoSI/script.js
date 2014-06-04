function putLike(news_id, user_id)
{	
	var url;
	var data;
	
	if(document.getElementById(news_id).alt == "Like")
	{
		document.getElementById(news_id).src="like.png";
		document.getElementById(news_id).alt = "Dislike";

		url = "like.php";
		data = "news=" + news_id + "&user=" + user_id;
		$.ajax(url, {data: data, type: "POST"});
	}
	else if(document.getElementById(news_id).alt == "Dislike")
	{
		document.getElementById(news_id).src="like_cont.png";
		document.getElementById(news_id).alt = "Like";

		url = "like.php";
		data = "news=" + news_id + "&user=" + user_id;
		$.ajax(url, {data: data, type: "POST"});
	}
}

function putComment(text, user_id, news_id)
{	
	var url = "addComment.php";
	var data = "text=" + text.value + "&user=" + user_id + "&news=" + news_id;
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result == 'OK')
			{
				$('#aux').remove();
				
				var $header = $('div.comments_show');
				var $anchor = $('<div id="aux">').appendTo($header);
				for(var i = 0; i < $s.data_comments.length; i++)
				{
					var $div = $('<div id='+$s.data_comments[i].id+'>');
					$anchor.append($div);
					$('<p>'+$s.data_comments[i].comment+'</p>').appendTo($div);
					var $div_sep = $('<div id="image_autor">').appendTo($div);
					$('<img src="user.png" alt="Autor" height="25" width="25" />').appendTo($div_sep);
					$('<p>'+$s.data_comments[i].autor+'</p>').appendTo($div_sep);
					$('</div>').appendTo($div);
					
					for(var j = 0; j < $s.data_valid_comments.length; j++)
					{
						if(($s.data_comments[i].id == $s.data_valid_comments[j].id) && ($s.data_comments[i].comment == $s.data_valid_comments[j].comment) && ($s.data_comments[i].autor == $s.data_valid_comments[j].autor))
						{
							$('<input id="delete" type="image" src="delete.png" alt="Delete" width="25" height="25" onclick="deleteComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							$('<input id="edit" type="image" src="edit.png" alt="Edit" width="25" height="25" onclick="editComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							break;
						}
					}
					
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					var $end_div = $('</div>');
					$anchor.append($end_div);
					$('</div>').appendTo($header);
				}
			}
		}
	});	
}


function viewNewNews() {
	var lastid = 0;
setInterval(function() {
 var urlteste = "lastnewsid.php";
 
 jQuery.ajax({
  url: urlteste,
  success: function(s)
  {
   if(lastid == 0)
    lastid = s;
    
   else if(lastid < s)
   {
    lastid = s;
    alert('Foram adicionadas novas noticias na base de dados do sistema');
   }
  },
  
  error: function(s)
  {
   alert('ERROR');
  },
  
  complete: function(s)
  {
   //alert('COMPLETE');
  },
  type: 'GET'
 });
 }, 15000);
}

function loadComments(news_id)
{
	var url = "loadComments.php?news="+news_id;
	var data;
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result == 'OK')
			{
				var $header = $('div.comments_show');
				var $anchor = $('<div id="aux">').appendTo($header);
				for(var i = 0; i < $s.data_comments.length; i++)
				{
					var $div = $('<div id='+$s.data_comments[i].id+'>');
					$anchor.append($div);
					$('<p>'+$s.data_comments[i].comment+'</p>').appendTo($div);
					var $div_sep = $('<div id="image_autor">').appendTo($div);
					$('<img src="user.png" alt="Autor" height="25" width="25" />').appendTo($div_sep);
					$('<p>'+$s.data_comments[i].autor+'</p>').appendTo($div_sep);
					$('</div>').appendTo($div);
					
					for(var j = 0; j < $s.data_valid_comments.length; j++)
					{
						if(($s.data_comments[i].id == $s.data_valid_comments[j].id) && ($s.data_comments[i].comment == $s.data_valid_comments[j].comment) && ($s.data_comments[i].autor == $s.data_valid_comments[j].autor))
						{
							$('<input id="delete" type="image" src="delete.png" alt="Delete" width="25" height="25" onclick="deleteComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							$('<input id="edit" type="image" src="edit.png" alt="Edit" width="25" height="25" onclick="editComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							break;
						}
					}
					
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					var $end_div = $('</div>');
					$anchor.append($end_div);
					$('</div>').appendTo($header);
				}
			}
		}
	});	
}

function deleteComment(id_comment, news_id)
{
	var url = "deleteComment.php";
	var data = "comment=" + id_comment + "&news=" + news_id;
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result == 'OK')
			{		
				$('#aux').remove();
				
				var $header = $('div.comments_show');
				var $anchor = $('<div id="aux">').appendTo($header);
				for(var i = 0; i < $s.data_comments.length; i++)
				{
					var $div = $('<div id='+$s.data_comments[i].id+'>');
					$anchor.append($div);
					$('<p>'+$s.data_comments[i].comment+'</p>').appendTo($div);
					var $div_sep = $('<div id="image_autor">').appendTo($div);
					$('<img src="user.png" alt="Autor" height="25" width="25" />').appendTo($div_sep);
					$('<p>'+$s.data_comments[i].autor+'</p>').appendTo($div_sep);
					$('</div>').appendTo($div);
					
					for(var j = 0; j < $s.data_valid_comments.length; j++)
					{
						if(($s.data_comments[i].id == $s.data_valid_comments[j].id) && ($s.data_comments[i].comment == $s.data_valid_comments[j].comment) && ($s.data_comments[i].autor == $s.data_valid_comments[j].autor))
						{
							$('<input id="delete" type="image" src="delete.png" alt="Delete" width="25" height="25" onclick="deleteComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							$('<input id="edit" type="image" src="edit.png" alt="Edit" width="25" height="25" onclick="editComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							break;
						}
					}
					
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					var $end_div = $('</div>');
					$anchor.append($end_div);
					$('</div>').appendTo($header);
				}
			}
		}
	});	
}

function editComment(id_comment, news_id)
{
	var url = "loadComments.php?news="+news_id;
	var data;
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result == 'OK')
			{
				$('#aux').remove();
				
				var $header = $('div.comments_show');
				var $anchor = $('<div id="aux">').appendTo($header);
				for(var i = 0; i < $s.data_comments.length; i++)
				{
					var $div = $('<div id='+$s.data_comments[i].id+'>');
					$anchor.append($div);
					if($s.data_comments[i].id == id_comment)
					{
						var $form = $('<form id="comentario_img" method="post">').appendTo($div); 
						$('<textarea id="comment" name="text" rows="4" cols="80">'+$s.data_comments[i].comment+'</textarea>').appendTo($form);
						$('</br>').appendTo($form);
						$('<button id="button_r" onClick="updateComment(text ,'+id_comment+','+news_id+');return false"> Actualizar comentário </button>').appendTo($form);
						var $end_form = $('</form>').appendTo($div);
					}
					else
					{
						$('<p>'+$s.data_comments[i].comment+'</p>').appendTo($div);
					}
					var $div_sep = $('<div id="image_autor">').appendTo($div);
					$('<img src="user.png" alt="Autor" height="25" width="25" />').appendTo($div_sep);
					$('<p>'+$s.data_comments[i].autor+'</p>').appendTo($div_sep);
					$('</div>').appendTo($div);
					
					for(var j = 0; j < $s.data_valid_comments.length; j++)
					{
						if(($s.data_comments[i].id != id_comment) && ($s.data_comments[i].id == $s.data_valid_comments[j].id) && ($s.data_comments[i].comment == $s.data_valid_comments[j].comment) && ($s.data_comments[i].autor == $s.data_valid_comments[j].autor))
						{
							$('<input id="delete" type="image" src="delete.png" alt="Delete" width="25" height="25" onclick="deleteComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							$('<input id="edit" type="image" src="edit.png" alt="Edit" width="25" height="25" onclick="editComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							break;
						}
					}
					
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					var $end_div = $('</div>');
					$anchor.append($end_div);
					$('</div>').appendTo($header);
				}
			}
		}
	});	
}

function updateComment(text, comment_id, news_id)
{	
	var url = "updateComment.php";
	var data = "text=" + text.value + "&comment=" + comment_id + "&news=" + news_id;
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result == 'OK')
			{
				$('#aux').remove();
				
				var $header = $('div.comments_show');
				var $anchor = $('<div id="aux">').appendTo($header);
				for(var i = 0; i < $s.data_comments.length; i++)
				{
					var $div = $('<div id='+$s.data_comments[i].id+'>');
					$anchor.append($div);
					$('<p>'+$s.data_comments[i].comment+'</p>').appendTo($div);
					var $div_sep = $('<div id="image_autor">').appendTo($div);
					$('<img src="user.png" alt="Autor" height="25" width="25" />').appendTo($div_sep);
					$('<p>'+$s.data_comments[i].autor+'</p>').appendTo($div_sep);
					$('</div>').appendTo($div);
					
					for(var j = 0; j < $s.data_valid_comments.length; j++)
					{
						if(($s.data_comments[i].id == $s.data_valid_comments[j].id) && ($s.data_comments[i].comment == $s.data_valid_comments[j].comment) && ($s.data_comments[i].autor == $s.data_valid_comments[j].autor))
						{
							$('<input id="delete" type="image" src="delete.png" alt="Delete" width="25" height="25" onclick="deleteComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							$('<input id="edit" type="image" src="edit.png" alt="Edit" width="25" height="25" onclick="editComment('+$s.data_comments[i].id+','+news_id+');return false"/>').appendTo($div);
							break;
						}
					}
					
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					$('</br>').appendTo($div);
					var $end_div = $('</div>');
					$anchor.append($end_div);
					$('</div>').appendTo($header);
				}
			}
		}
	});	
}

function addNews(titulo, text, tags)
{
	var url = "databaseaddnews.php";
	var data = "text=" + text.value + "&titulo=" + titulo.value + "&tags=" + tags.value;
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result === 'OK')
			{
				window.location = 'index.php';
			} 
		}
	});
}

function receiveJSON(site, tags, init, final_d)
{
	var data;
	var url_json = site.value + "?start_date=" + init.value + "&end_date=" + final_d.value + "&tags=" + tags.value;
	
	$.ajax({
		url: url_json,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			var title;
			var date;
			var	text;
			var user_author;
			var url_news;
			var reason;
			
			if($s.result == "success")
			{
				for(var m = 0; m < $s.data.length; m++)
				{
					alert("A interpretar a "+(m+1)+"ª noticia...");
					
					title = $s.data[m].title;
					date = $s.data[m].date;
					text = $s.data[m].text;
					user_author = $s.data[m].posted_by;
					url_news = $s.data[m].url;
					
					addImportedNews(title, date, text, user_author, url_news); 
					
					for(var n = 0; n < $s.data[m].tags.length; n++)
					{
						addTags($s.data[m].tags[n], date, user_author);
					}
				}
				
				window.location = 'index.php';
			}
			else if($s.result == "error")
			{
				alert("Error: "+$s.reason+ "!");
				window.location = 'index.php';
			}
		}
	});
}

function addImportedNews(title, date, text, user_author, url_news)
{
	var url = "addimportednews.php";
	var data = "title=" + title + "&date=" + date + "&text=" + text + "&user_author=" + user_author + "&url=" + url_news;
	
	alert("A ler noticia...");
	
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result == 'OK')
			{
				
			}
		}
	});
}

function addTags(tag, date, user_author)
{
	var url = "addimportedtags.php";
	var data = "tag="+ tag +"&date="+ date +"&user_author="+ user_author;
	
	alert("A ler tag "+tag+" ...");
	
	$.ajax({
		url: url,
		dataType: 'json',
		data: data, 
		type: "POST",
		success: function($s)
		{
			if($s.result == 'OK')
			{
				
			}
		}
	});
}
