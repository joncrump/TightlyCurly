<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GoogleTranslator.ascx.cs" Inherits="TightlyCurly.Com.Web.UserControls.DataControls.GoogleTranslator" %>
Translate this page:
&nbsp;
<select onchange="translate(this.options[this.selectedIndex].value);">
    <option value="en|de">deutsch</option>
    <option value="en|pt">português</option>
    <option value="en|fr">français</option>
    <option value="en|ja">日本語</option>
    <option value="en|ar">عَرَبيْ</option>
    <option value="en|it">italiano</option>
    <option value="en|ru">pусский</option>
    <option value="en|po">polski</option>
    <option value="en|zh-CN">中文</option>
    <option value="en|es">español</option>
    <option value="en|ko">한국어</option>
    <option value="en|nl">nederlands</option>
    <option value="en|hi">हिन्दी </option>
    <option value="en|el">Ελληνική</option>
    <option value="en|ro">română</option>
</select>