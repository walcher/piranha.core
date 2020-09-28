/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;
using System.Collections.Generic;

namespace Piranha.Manager.Models
{
    public class ContentEditModel
    {
        /// <summary>
        /// Gets/sets the unique id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets/sets the optional language id.
        /// </summary>
        public Guid? LanguageId { get; set; }

        /// <summary>
        /// Gets/sets the content type id.
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// Gets/sets the mandatory title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets/sets if blocks should be used.
        /// </summary>
        public bool UseBlocks { get; set; } = true;

        /// <summary>
        /// Gets/sets if the content type should be
        /// categorized.
        /// </summary>
        public bool UseCategory { get; set; }

        /// <summary>
        /// Gets/sets if excerpt should be used for the
        /// content type. The default value is true.
        /// </summary>
        public bool UseExcerpt { get; set; } = true;

        /// <summary>
        /// Gets/sets if primary image should be used for the
        /// content type. The default value is true.
        /// </summary>
        public bool UsePrimaryImage { get; set; } = true;

        /// <summary>
        /// Gets/sets if tags should be used for the content type.
        /// </summary>
        public bool UseTags { get; set; }

        /// <summary>
        /// Gets/sets if the content should be translatable.
        /// </summary>
        public bool UseTranslations { get; set; }

        /// <summary>
        /// Gets/sets the available blocks.
        /// </summary>
        public IList<Content.BlockModel> Blocks { get; set; } = new List<Content.BlockModel>();

        /// <summary>
        /// Gets/sets the available regions.
        /// </summary>
        public IList<Content.RegionModel> Regions { get; set; } = new List<Content.RegionModel>();

        /// <summary>
        /// Gets/sets the available custom editors.
        /// </summary>
        public IList<Content.EditorModel> Editors { get; set; } = new List<Content.EditorModel>();
    }
}