"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.successIconMarkup = exports.warningIconMarkup = exports.errorIconMarkup = void 0;
var class_list_1 = require("../class-list");
var ICON = class_list_1.default.ICON;
var errorIconMarkup = function () {
    var icon = ICON + "--error";
    var line = icon + "__line";
    var markup = "\n    <div class=\"" + icon + "__x-mark\">\n      <span class=\"" + line + " " + line + "--left\"></span>\n      <span class=\"" + line + " " + line + "--right\"></span>\n    </div>\n  ";
    return markup;
};
exports.errorIconMarkup = errorIconMarkup;
var warningIconMarkup = function () {
    var icon = ICON + "--warning";
    return "\n    <span class=\"" + icon + "__body\">\n      <span class=\"" + icon + "__dot\"></span>\n    </span>\n  ";
};
exports.warningIconMarkup = warningIconMarkup;
var successIconMarkup = function () {
    var icon = ICON + "--success";
    return "\n    <span class=\"" + icon + "__line " + icon + "__line--long\"></span>\n    <span class=\"" + icon + "__line " + icon + "__line--tip\"></span>\n\n    <div class=\"" + icon + "__ring\"></div>\n    <div class=\"" + icon + "__hide-corners\"></div>\n  ";
};
exports.successIconMarkup = successIconMarkup;
//# sourceMappingURL=icons.js.map