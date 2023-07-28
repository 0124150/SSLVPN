﻿using System;
using System.Collections.Generic;
using SSCMS.Core.StlParser.StlElement;

namespace SSCMS.Core.StlParser.Models
{
    public static class StlAll
    {
        public static SortedList<string, Type> Elements => new SortedList<string, Type>
        {
            {
                StlA.ElementName,
                typeof(StlA)
            },
            {
                StlAction.ElementName,
                typeof(StlAction)
            },
            {
                StlAudio.ElementName,
                typeof(StlAudio)
            },
            {
                StlChannel.ElementName,
                typeof(StlChannel)
            },
            {
                StlChannels.ElementName,
                typeof(StlChannels)
            },
            {
                StlContainer.ElementName,
                typeof(StlContainer)
            },
            {
                StlContent.ElementName,
                typeof(StlContent)
            },
            {
                StlContents.ElementName,
                typeof(StlContents)
            },
            {
                StlCount.ElementName,
                typeof(StlCount)
            },
            {
                StlDynamic.ElementName,
                typeof(StlDynamic)
            },
            {
                StlEach.ElementName,
                typeof(StlEach)
            },
            {
                StlEditable.ElementName,
                typeof(StlEditable)
            },
            {
                StlFile.ElementName,
                typeof(StlFile)
            },
            {
                StlFocusViewer.ElementName,
                typeof(StlFocusViewer)
            },
            {
                StlForm.ElementName,
                typeof(StlForm)
            },
            {
                StlIf.ElementName,
                typeof(StlIf)
            },
            {
                StlImage.ElementName,
                typeof(StlImage)
            },
            {
                StlInclude.ElementName,
                typeof(StlInclude)
            },
            {
                StlItemTemplate.ElementName,
                typeof(StlItemTemplate)
            },
            {
                StlLayer.ElementName,
                typeof(StlLayer)
            },
            {
                StlLoading.ElementName,
                typeof(StlLoading)
            },
            {
                StlLocation.ElementName,
                typeof(StlLocation)
            },
            {
                StlMap.ElementName,
                typeof(StlMap)
            },
            {
                StlMarquee.ElementName,
                typeof(StlMarquee)
            },
            {
                StlMaterial.ElementName,
                typeof(StlMaterial)
            },
            {
                StlMore.ElementName,
                typeof(StlMore)
            },
            {
                StlNavigation.ElementName,
                typeof(StlNavigation)
            },
            {
                StlNo.ElementName,
                typeof(StlNo)
            },
            {
                StlPageChannels.ElementName,
                typeof(StlPageChannels)
            },
            {
                StlPageContents.ElementName,
                typeof(StlPageContents)
            },
            {
                StlPageItem.ElementName,
                typeof(StlPageItem)
            },
            {
                StlPageItems.ElementName,
                typeof(StlPageItems)
            },
            {
                StlPageSqlContents.ElementName,
                typeof(StlPageSqlContents)
            },
            {
                StlPdf.ElementName,
                typeof(StlPdf)
            },
            {
                StlPlayer.ElementName,
                typeof(StlPlayer)
            },
            {
                StlPrinter.ElementName,
                typeof(StlPrinter)
            },
            {
                StlQueryString.ElementName,
                typeof(StlQueryString)
            },
            {
                StlRequest.ElementName,
                typeof(StlRequest)
            },
            {
                StlSearch.ElementName,
                typeof(StlSearch)
            },
            {
                StlSelect.ElementName,
                typeof(StlSelect)
            },
            {
                StlShare.ElementName,
                typeof(StlShare)
            },
            {
                StlSite.ElementName,
                typeof(StlSite)
            },
            {
                StlSites.ElementName,
                typeof(StlSites)
            },
            {
                StlSqlContent.ElementName,
                typeof(StlSqlContent)
            },
            {
                StlSqlContents.ElementName,
                typeof(StlSqlContents)
            },
            {
                StlStyle.ElementName,
                typeof(StlStyle)
            },
            {
                StlSwiper.ElementName,
                typeof(StlSwiper)
            },
            {
                StlTabs.ElementName,
                typeof(StlTabs)
            },
            {
                StlTags.ElementName,
                typeof(StlTags)
            },
            {
                StlUser.ElementName,
                typeof(StlUser)
            },
            {
                StlValue.ElementName,
                typeof(StlValue)
            },
            {
                StlVideo.ElementName,
                typeof(StlVideo)
            },
            {
                StlYes.ElementName,
                typeof(StlYes)
            },
            {
                StlZoom.ElementName,
                typeof(StlZoom)
            }
        };
    }
}
